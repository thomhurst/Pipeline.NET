using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("networkcloud", "baremetalmachine", "power-off")]
public record AzNetworkcloudBaremetalmachinePowerOffOptions(
[property: CommandSwitch("--limit-time-seconds")] string LimitTimeSeconds,
[property: CommandSwitch("--script")] string Script
) : AzOptions
{
    [CommandSwitch("--bare-metal-machine-name")]
    public string? BareMetalMachineName { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [BooleanCommandSwitch("--skip-shutdown")]
    public bool? SkipShutdown { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}