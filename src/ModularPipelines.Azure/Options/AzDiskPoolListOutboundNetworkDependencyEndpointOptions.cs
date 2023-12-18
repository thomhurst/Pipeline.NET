using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("disk-pool", "list-outbound-network-dependency-endpoint")]
public record AzDiskPoolListOutboundNetworkDependencyEndpointOptions(
[property: CommandSwitch("--disk-pool-name")] string DiskPoolName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}