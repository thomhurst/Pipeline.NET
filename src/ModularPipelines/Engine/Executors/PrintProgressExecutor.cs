﻿using ModularPipelines.Helpers;
using ModularPipelines.Models;
using ModularPipelines.Modules;

namespace ModularPipelines.Engine.Executors;

internal class PrintProgressExecutor : IPrintProgressExecutor
{
    private readonly EngineCancellationToken _engineCancellationToken;
    private readonly IConsolePrinter _consolePrinter;

    public PrintProgressExecutor(EngineCancellationToken engineCancellationToken,
        IConsolePrinter consolePrinter)
    {
        _engineCancellationToken = engineCancellationToken;
        _consolePrinter = consolePrinter;
    }
    
    public async Task<IReadOnlyList<ModuleBase>> ExecuteWithProgress(OrganizedModules organizedModules, Func<Task<IReadOnlyList<ModuleBase>>> executeDelegate)
    {
        var printProgressCancellationTokenSource =
            CancellationTokenSource.CreateLinkedTokenSource(_engineCancellationToken.Token);

        var printProgressTask =
            _consolePrinter.PrintProgress(organizedModules, printProgressCancellationTokenSource.Token);
        
        try
        {
            return await executeDelegate();
        }
        finally
        {
            printProgressCancellationTokenSource.CancelAfter(1500);

            await printProgressTask;
        }
    }
}