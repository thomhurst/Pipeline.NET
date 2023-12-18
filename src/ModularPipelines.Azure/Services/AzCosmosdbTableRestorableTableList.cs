using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "table", "restorable-table")]
public class AzCosmosdbTableRestorableTableList
{
    public AzCosmosdbTableRestorableTableList(
        AzCosmosdbTableRestorableTableListCosmosdbPreview cosmosdbPreview
    )
    {
        CosmosdbPreview = cosmosdbPreview;
    }

    public AzCosmosdbTableRestorableTableListCosmosdbPreview CosmosdbPreview { get; }
}