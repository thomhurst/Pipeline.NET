using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "gremlin", "restorable-resource")]
public class AzCosmosdbGremlinRestorableResourceList
{
    public AzCosmosdbGremlinRestorableResourceList(
        AzCosmosdbGremlinRestorableResourceListCosmosdbPreview cosmosdbPreview
    )
    {
        CosmosdbPreview = cosmosdbPreview;
    }

    public AzCosmosdbGremlinRestorableResourceListCosmosdbPreview CosmosdbPreview { get; }
}

