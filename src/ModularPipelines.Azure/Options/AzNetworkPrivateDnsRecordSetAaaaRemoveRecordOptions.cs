using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network", "private-dns", "record-set", "aaaa", "remove-record")]
public record AzNetworkPrivateDnsRecordSetAaaaRemoveRecordOptions(
[property: CommandSwitch("--ipv6-address")] string Ipv6Address,
[property: CommandSwitch("--record-set-name")] string RecordSetName,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--zone-name")] string ZoneName
) : AzOptions
{
    [BooleanCommandSwitch("--keep-empty-record-set")]
    public bool? KeepEmptyRecordSet { get; set; }
}