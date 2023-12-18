using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sphere", "device", "image", "list-installed")]
public record AzSphereDeviceImageListInstalledOptions : AzOptions
{
    [CommandSwitch("--device")]
    public string? Device { get; set; }

    [BooleanCommandSwitch("--full")]
    public bool? Full { get; set; }
}