using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cdn", "waf", "policy", "managed-rule-set", "rule-group-override", "set")]
public record AzCdnWafPolicyManagedRuleSetRuleGroupOverrideSetOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--rule-override")] string RuleOverride,
[property: CommandSwitch("--rule-set-type")] string RuleSetType,
[property: CommandSwitch("--rule-set-version")] string RuleSetVersion
) : AzOptions
{
    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--policy-name")]
    public string? PolicyName { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}