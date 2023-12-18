using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("security", "alerts-suppression-rule", "delete_scope")]
public record AzSecurityAlertsSuppressionRuleDelete_scopeOptions(
[property: CommandSwitch("--field")] string Field,
[property: CommandSwitch("--rule-name")] string RuleName
) : AzOptions
{
    [CommandSwitch("--comment")]
    public string? Comment { get; set; }

    [CommandSwitch("--expiration-date-utc")]
    public string? ExpirationDateUtc { get; set; }
}