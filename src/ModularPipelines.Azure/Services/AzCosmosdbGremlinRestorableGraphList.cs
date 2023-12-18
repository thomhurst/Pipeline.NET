using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "gremlin", "restorable-graph")]
public class AzCosmosdbGremlinRestorableGraphList
{
    public AzCosmosdbGremlinRestorableGraphList(
        AzCosmosdbGremlinRestorableGraphListCosmosdbPreview cosmosdbPreview
    )
    {
        CosmosdbPreview = cosmosdbPreview;
    }

    public AzCosmosdbGremlinRestorableGraphListCosmosdbPreview CosmosdbPreview { get; }
}