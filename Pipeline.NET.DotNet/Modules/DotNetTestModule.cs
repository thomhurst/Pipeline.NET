﻿using CliWrap.Buffered;
using Pipeline.NET.Context;
using Pipeline.NET.DotNet.Options;
using Pipeline.NET.Models;
using Pipeline.NET.Modules;

namespace Pipeline.NET.DotNet.Modules;

public abstract class DotNetTestModule : Module<BufferedCommandResult>
{
    protected DotNetTestModule(IModuleContext context) : base(context)
    {
    }

    protected abstract DotNetModuleOptions Options { get; }

    protected override async Task<ModuleResult<BufferedCommandResult>?> ExecuteAsync(CancellationToken cancellationToken)
    {
        var internalDotNetCommandModule = new InternalDotNetCommandModule(Context, new DotNetCommandModuleOptions()
        {
            Command = "test",
            ExtraArguments = Options.ExtraArguments,
            ProjectOrSolutionPath = Options.ProjectOrSolutionPath,
            WorkingDirectory = Options.WorkingDirectory
        });
        
        await internalDotNetCommandModule.StartProcessingModule();

        return await internalDotNetCommandModule;
    }
}