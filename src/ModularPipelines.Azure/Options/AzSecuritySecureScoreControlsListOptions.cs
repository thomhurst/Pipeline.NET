using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("security", "secure-score-controls", "list")]
public record AzSecuritySecureScoreControlsListOptions(
[property: CommandSwitch("--name")] string Name
) : AzOptions
{
}

