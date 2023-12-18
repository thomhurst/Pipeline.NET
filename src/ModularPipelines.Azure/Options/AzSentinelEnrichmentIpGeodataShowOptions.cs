using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sentinel", "enrichment", "ip-geodata", "show")]
public record AzSentinelEnrichmentIpGeodataShowOptions(
[property: CommandSwitch("--ip-address")] string IpAddress,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
}