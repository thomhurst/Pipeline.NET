using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "sql", "container")]
public class AzCosmosdbSqlContainerCreate
{
    public AzCosmosdbSqlContainerCreate(
        AzCosmosdbSqlContainerCreateCosmosdbPreview cosmosdbPreview
    )
    {
        CosmosdbPreview = cosmosdbPreview;
    }

    public AzCosmosdbSqlContainerCreateCosmosdbPreview CosmosdbPreview { get; }
}