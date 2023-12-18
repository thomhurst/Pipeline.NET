using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("feature", "show")]
public record AzFeatureShowOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--namespace")] string Namespace
) : AzOptions;