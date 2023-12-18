using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "mongodb", "role", "definition", "list", "(cosmosdb-preview", "extension)")]
public record AzCosmosdbMongodbRoleDefinitionListCosmosdbPreviewExtensionOptions(
[property: CommandSwitch("--account-name")] int AccountName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
}