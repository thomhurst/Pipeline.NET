using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network", "front-door", "rules-engine", "rule", "delete")]
public record AzNetworkFrontDoorRulesEngineRuleDeleteOptions(
[property: CommandSwitch("--front-door-name")] string FrontDoorName,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--rules-engine-name")] string RulesEngineName
) : AzOptions
{
    [CommandSwitch("--match-processing-behavior")]
    public string? MatchProcessingBehavior { get; set; }

    [CommandSwitch("--priority")]
    public string? Priority { get; set; }
}

