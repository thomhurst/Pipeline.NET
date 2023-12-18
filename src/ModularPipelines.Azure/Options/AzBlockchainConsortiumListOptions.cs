using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("blockchain", "consortium", "list")]
public record AzBlockchainConsortiumListOptions(
[property: CommandSwitch("--location")] string Location
) : AzOptions
{
}