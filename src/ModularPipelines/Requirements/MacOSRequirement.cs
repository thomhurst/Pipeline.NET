﻿using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Context;

namespace ModularPipelines.Requirements;

[ExcludeFromCodeCoverage]
public class MacOSRequirement : IPipelineRequirement
{
    /// <inheritdoc/>
    public Task<bool> MustAsync(IPipelineHookContext context)
    {
        return Task.FromResult(context.Environment.OperatingSystem == OperatingSystemIdentifier.MacOS);
    }
}