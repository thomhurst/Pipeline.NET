using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("automanage", "best-practice", "show")]
public record AzAutomanageBestPracticeShowOptions(
[property: CommandSwitch("--best-practice-name")] string BestPracticeName
) : AzOptions
{
}

