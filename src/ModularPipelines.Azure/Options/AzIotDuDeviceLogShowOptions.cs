using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iot", "du", "device", "log", "show")]
public record AzIotDuDeviceLogShowOptions(
[property: CommandSwitch("--account")] int Account,
[property: CommandSwitch("--instance")] string Instance,
[property: CommandSwitch("--lcid")] string Lcid
) : AzOptions
{
    [BooleanCommandSwitch("--detailed")]
    public bool? Detailed { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}