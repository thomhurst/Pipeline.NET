using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
public class AzEventhubs
{
    public AzEventhubs(
        AzEventhubsCluster cluster,
        AzEventhubsEventhub eventhub,
        AzEventhubsGeorecoveryAlias georecoveryAlias,
        AzEventhubsNamespace @namespace
    )
    {
        Cluster = cluster;
        Eventhub = eventhub;
        GeorecoveryAlias = georecoveryAlias;
        Namespace = @namespace;
    }

    public AzEventhubsCluster Cluster { get; }

    public AzEventhubsEventhub Eventhub { get; }

    public AzEventhubsGeorecoveryAlias GeorecoveryAlias { get; }

    public AzEventhubsNamespace Namespace { get; }
}