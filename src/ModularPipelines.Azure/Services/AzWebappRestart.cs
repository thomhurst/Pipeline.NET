using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("webapp")]
public class AzWebappRestart
{
    public AzWebappRestart(
        AzWebappRestartAppserviceKube appserviceKube
    )
    {
        AppserviceKube = appserviceKube;
    }

    public AzWebappRestartAppserviceKube AppserviceKube { get; }
}