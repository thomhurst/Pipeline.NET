using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network", "front-door", "rules-engine", "rule", "condition", "remove")]
public record AzNetworkFrontDoorRulesEngineRuleConditionRemoveOptions(
[property: CommandSwitch("--front-door-name")] string FrontDoorName,
[property: CommandSwitch("--index")] string Index,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--rules-engine-name")] string RulesEngineName
) : AzOptions
{
}