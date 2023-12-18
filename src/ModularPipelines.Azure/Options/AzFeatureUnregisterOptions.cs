using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("feature", "unregister")]
public record AzFeatureUnregisterOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--namespace")] string Namespace
) : AzOptions
{
}