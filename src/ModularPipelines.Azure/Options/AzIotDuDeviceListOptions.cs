using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iot", "du", "device", "list")]
public record AzIotDuDeviceListOptions(
[property: CommandSwitch("--account")] int Account,
[property: CommandSwitch("--instance")] string Instance
) : AzOptions
{
    [CommandSwitch("--filter")]
    public string? Filter { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}

