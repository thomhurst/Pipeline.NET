using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("managed-cassandra", "datacenter")]
public class AzManagedCassandraDatacenterCreate
{
    public AzManagedCassandraDatacenterCreate(
        AzManagedCassandraDatacenterCreateCosmosdbPreview cosmosdbPreview
    )
    {
        CosmosdbPreview = cosmosdbPreview;
    }

    public AzManagedCassandraDatacenterCreateCosmosdbPreview CosmosdbPreview { get; }
}