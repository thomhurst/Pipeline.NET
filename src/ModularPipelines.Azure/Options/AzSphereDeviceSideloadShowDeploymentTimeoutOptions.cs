using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sphere", "device", "sideload", "show-deployment-timeout")]
public record AzSphereDeviceSideloadShowDeploymentTimeoutOptions : AzOptions
{
}