using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("dla", "account", "firewall", "create")]
public record AzDlaAccountFirewallCreateOptions(
[property: CommandSwitch("--account")] int Account,
[property: CommandSwitch("--end-ip-address")] string EndIpAddress,
[property: CommandSwitch("--firewall-rule-name")] string FirewallRuleName,
[property: CommandSwitch("--start-ip-address")] string StartIpAddress
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}

