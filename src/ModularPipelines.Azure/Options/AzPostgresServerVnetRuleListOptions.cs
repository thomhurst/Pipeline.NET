using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("postgres", "server", "vnet-rule", "list")]
public record AzPostgresServerVnetRuleListOptions : AzOptions
{
    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--server-name")]
    public string? ServerName { get; set; }

    [CommandSwitch("--subscription")]
    public new string? Subscription { get; set; }
}