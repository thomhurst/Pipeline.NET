using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sphere", "device", "network", "show-status")]
public record AzSphereDeviceNetworkShowStatusOptions(
[property: CommandSwitch("--hardware-address")] string HardwareAddress,
[property: CommandSwitch("--interface")] string Interface
) : AzOptions
{
    [CommandSwitch("--device")]
    public string? Device { get; set; }
}