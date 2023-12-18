using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("security", "pricing", "show")]
public record AzSecurityPricingShowOptions(
[property: CommandSwitch("--name")] string Name
) : AzOptions
{
}