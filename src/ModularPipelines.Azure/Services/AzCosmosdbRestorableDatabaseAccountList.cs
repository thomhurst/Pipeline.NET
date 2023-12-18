using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "restorable-database-account")]
public class AzCosmosdbRestorableDatabaseAccountList
{
    public AzCosmosdbRestorableDatabaseAccountList(
        AzCosmosdbRestorableDatabaseAccountListCosmosdbPreview cosmosdbPreview
    )
    {
        CosmosdbPreview = cosmosdbPreview;
    }

    public AzCosmosdbRestorableDatabaseAccountListCosmosdbPreview CosmosdbPreview { get; }
}