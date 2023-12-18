using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "account", "or-policy", "rule", "list")]
public record AzStorageAccountOrPolicyRuleListOptions(
[property: CommandSwitch("--account-name")] int AccountName,
[property: CommandSwitch("--policy-id")] string PolicyId
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}