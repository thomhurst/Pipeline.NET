using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("servicebus", "topic", "authorization-rule", "create")]
public record AzServicebusTopicAuthorizationRuleCreateOptions(
[property: CommandSwitch("--authorization-rule-name")] string AuthorizationRuleName,
[property: CommandSwitch("--namespace-name")] string NamespaceName,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--topic-name")] string TopicName
) : AzOptions
{
    [CommandSwitch("--rights")]
    public string? Rights { get; set; }
}

