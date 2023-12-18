using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sphere", "device", "network", "proxy", "delete")]
public record AzSphereDeviceNetworkProxyDeleteOptions : AzOptions
{
    [CommandSwitch("--device")]
    public string? Device { get; set; }
}

