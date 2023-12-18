using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "table", "restorable-resource", "list")]
public record AzCosmosdbTableRestorableResourceListOptions(
[property: CommandSwitch("--instance-id")] string InstanceId,
[property: CommandSwitch("--location")] string Location,
[property: CommandSwitch("--restore-location")] string RestoreLocation,
[property: CommandSwitch("--restore-timestamp")] string RestoreTimestamp
) : AzOptions
{
}