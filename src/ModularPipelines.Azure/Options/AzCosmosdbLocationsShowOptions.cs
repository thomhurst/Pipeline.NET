using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "locations", "show")]
public record AzCosmosdbLocationsShowOptions(
[property: CommandSwitch("--location")] string Location
) : AzOptions
{
}

