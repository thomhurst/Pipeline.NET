using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iot", "du", "device", "health", "list")]
public record AzIotDuDeviceHealthListOptions(
[property: CommandSwitch("--account")] int Account,
[property: CommandSwitch("--filter")] string Filter,
[property: CommandSwitch("--instance")] string Instance
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}