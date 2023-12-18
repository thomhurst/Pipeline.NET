using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sql", "server", "ipv6-firewall-rule", "update")]
public record AzSqlServerIpv6FirewallRuleUpdateOptions : AzOptions
{
    [CommandSwitch("--end-ipv6-address")]
    public string? EndIpv6Address { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--name")]
    public string? Name { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--server")]
    public string? Server { get; set; }

    [CommandSwitch("--start-ipv6-address")]
    public string? StartIpv6Address { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}