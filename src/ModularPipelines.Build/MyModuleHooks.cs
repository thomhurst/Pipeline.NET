﻿using Microsoft.Extensions.Logging;
using ModularPipelines.Context;
using ModularPipelines.Interfaces;
using ModularPipelines.Modules;

namespace ModularPipelines.Build;

public class MyModuleHooks : IPipelineModuleHooks
{
    public Task OnBeforeModuleStartAsync(IPipelineContext pipelineContext, ModuleBase module)
    {
        pipelineContext.Logger.LogInformation("{Module} is starting at {DateTime}", module.GetType().Name, DateTimeOffset.UtcNow);
        return Task.CompletedTask;
    }

    public Task OnBeforeModuleEndAsync(IPipelineContext pipelineContext, ModuleBase module)
    {
        pipelineContext.Logger.LogInformation("{Module} finished at {DateTime} after {Elapsed}", module.GetType().Name, DateTimeOffset.UtcNow, module.Duration);
        return Task.CompletedTask;
    }
}
