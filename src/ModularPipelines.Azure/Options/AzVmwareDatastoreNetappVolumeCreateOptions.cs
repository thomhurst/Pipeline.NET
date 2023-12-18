using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("vmware", "datastore", "netapp-volume", "create")]
public record AzVmwareDatastoreNetappVolumeCreateOptions(
[property: CommandSwitch("--cluster")] string Cluster,
[property: CommandSwitch("--datastore-name")] string DatastoreName,
[property: CommandSwitch("--net-app-volumn")] string NetAppVolumn,
[property: CommandSwitch("--private-cloud")] string PrivateCloud,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }
}

