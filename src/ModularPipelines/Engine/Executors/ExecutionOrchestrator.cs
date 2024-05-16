using System.Diagnostics;
using Microsoft.Extensions.Logging;
using ModularPipelines.Helpers;
using ModularPipelines.Models;
using ModularPipelines.Modules;

namespace ModularPipelines.Engine.Executors;

internal class ExecutionOrchestrator : IExecutionOrchestrator
{
    private readonly IPipelineInitializer _pipelineInitializer;
    private readonly IWaitOrchestrator _waitOrchestrator;
    private readonly IModuleDisposeExecutor _moduleDisposeExecutor;
    private readonly IPrintModuleOutputExecutor _printModuleOutputExecutor;
    private readonly IPrintProgressExecutor _printProgressExecutor;
    private readonly IPipelineExecutor _pipelineExecutor;
    private readonly IConsolePrinter _consolePrinter;
    private readonly EngineCancellationToken _engineCancellationToken;
    private readonly ILogger<ExecutionOrchestrator> _logger;

    private readonly object _lock = new();

    private bool _hasRun;

    public ExecutionOrchestrator(IPipelineInitializer pipelineInitializer,
        IWaitOrchestrator waitOrchestrator,
        IModuleDisposeExecutor moduleDisposeExecutor,
        IPrintModuleOutputExecutor printModuleOutputExecutor,
        IPrintProgressExecutor printProgressExecutor,
        IPipelineExecutor pipelineExecutor,
        IConsolePrinter consolePrinter,
        EngineCancellationToken engineCancellationToken,
        ILogger<ExecutionOrchestrator> logger)
    {
        _pipelineInitializer = pipelineInitializer;
        _waitOrchestrator = waitOrchestrator;
        _moduleDisposeExecutor = moduleDisposeExecutor;
        _printModuleOutputExecutor = printModuleOutputExecutor;
        _printProgressExecutor = printProgressExecutor;
        _pipelineExecutor = pipelineExecutor;
        _consolePrinter = consolePrinter;
        _engineCancellationToken = engineCancellationToken;
        _logger = logger;
    }

    public async Task<PipelineSummary> ExecuteAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            return await ExecuteInternal(cancellationToken);
        }
        catch
        {
            // await _waitOrchestrator.WaitForFinish();
            throw;
        }
    }

    private async Task<PipelineSummary> ExecuteInternal(CancellationToken cancellationToken)
    {
        lock (_lock)
        {
            if (_hasRun)
            {
                throw new Exception("This pipeline has already been triggerred.");
            }

            _hasRun = true;
        }

        cancellationToken.Register(() => _engineCancellationToken.CancelWithReason("The user's cancellation token passed into the pipeline was cancelled."));

        var organizedModules = await _pipelineInitializer.Initialize();
        
        var runnableModules = organizedModules.RunnableModules.Select(x => x.Module).ToList();

        var start = DateTimeOffset.UtcNow;
        var stopWatch = Stopwatch.StartNew();
        
        var executePipelineTask = ExecutePipeline(runnableModules, organizedModules);

        var onEnd = await executePipelineTask.ContinueWith(t =>
                OnEnd(organizedModules, stopWatch, start, t.IsCompletedSuccessfully ? t.Result : null),
            CancellationToken.None);

        _ = onEnd.ContinueWith(_ => _waitOrchestrator.NotifyFinish(), CancellationToken.None);

        await executePipelineTask;
        
        return await onEnd;
    }

    private async Task<PipelineSummary> OnEnd(OrganizedModules organizedModules, Stopwatch stopWatch, DateTimeOffset start,
        PipelineSummary? pipelineSummary)
    {
        var end = DateTimeOffset.UtcNow;
        pipelineSummary ??= new PipelineSummary(organizedModules.AllModules, stopWatch.Elapsed, start, end);

        _consolePrinter.PrintResults(pipelineSummary);

        await Console.Out.FlushAsync();

        if (!string.IsNullOrEmpty(_engineCancellationToken.Reason))
        {
            _logger.LogInformation("Cancellation Reason: {Reason}", _engineCancellationToken.Reason);
        }
        
        return pipelineSummary;
    }

    private async Task<PipelineSummary> ExecutePipeline(List<ModuleBase> runnableModules, OrganizedModules organizedModules)
    {
        // Dispose and flush on scope leave - So including success or if an exception is thrown
        await using var moduleDisposeExecutor = _moduleDisposeExecutor;
        using var printModuleOutputExecutor = _printModuleOutputExecutor;
        await using var printProgressExecutor = await _printProgressExecutor.InitializeAsync();

        return await _pipelineExecutor.ExecuteAsync(runnableModules, organizedModules);
    }
}