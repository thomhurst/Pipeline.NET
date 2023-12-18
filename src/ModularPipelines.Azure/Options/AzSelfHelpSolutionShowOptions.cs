using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("self-help", "solution", "show")]
public record AzSelfHelpSolutionShowOptions(
[property: CommandSwitch("--scope")] string Scope,
[property: CommandSwitch("--solution-name")] string SolutionName
) : AzOptions
{
}