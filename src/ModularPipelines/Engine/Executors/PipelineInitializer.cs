﻿using Microsoft.Extensions.Logging;
using ModularPipelines.Helpers;
using ModularPipelines.Models;

namespace ModularPipelines.Engine.Executors;

internal class PipelineInitializer : IPipelineInitializer
{
    private readonly IDependencyDetector _dependencyDetector;
    private readonly IRequirementChecker _requirementsChecker;
    private readonly IModuleRetriever _moduleRetriever;
    private readonly IConsolePrinter _consolePrinter;
    private readonly IPipelineSetupExecutor _pipelineSetupExecutor;
    private readonly IBuildSystemDetector _buildSystemDetector;
    private readonly ILogger<PipelineInitializer> _logger;

    public PipelineInitializer(IConsolePrinter consolePrinter,
        IModuleRetriever moduleRetriever,
        IRequirementChecker requirementsChecker,
        IDependencyDetector dependencyDetector,
        IPipelineSetupExecutor pipelineSetupExecutor,
        IBuildSystemDetector buildSystemDetector,
        ILogger<PipelineInitializer> logger)
    {
        _consolePrinter = consolePrinter;
        _moduleRetriever = moduleRetriever;
        _requirementsChecker = requirementsChecker;
        _dependencyDetector = dependencyDetector;
        _pipelineSetupExecutor = pipelineSetupExecutor;
        _buildSystemDetector = buildSystemDetector;
        _logger = logger;
    }

    public async Task<OrganizedModules> Initialize()
    {
        _consolePrinter.PrintLogo();

        _logger.LogInformation("Detected Build System: {BuildSystem}", _buildSystemDetector.GetCurrentBuildSystem());
        
        _dependencyDetector.Check();

        await _pipelineSetupExecutor.OnStartAsync();

        await _requirementsChecker.CheckRequirementsAsync();

        return await _moduleRetriever.GetOrganizedModules();
    }
}