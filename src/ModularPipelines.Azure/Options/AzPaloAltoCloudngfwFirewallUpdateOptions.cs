using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("palo-alto", "cloudngfw", "firewall", "update")]
public record AzPaloAltoCloudngfwFirewallUpdateOptions : AzOptions
{
    [CommandSwitch("--add")]
    public string? Add { get; set; }

    [CommandSwitch("--firewall-name")]
    public string? FirewallName { get; set; }

    [BooleanCommandSwitch("--force-string")]
    public bool? ForceString { get; set; }

    [CommandSwitch("--identity")]
    public string? Identity { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }

    [CommandSwitch("--remove")]
    public string? Remove { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--set")]
    public string? Set { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }

    [CommandSwitch("--tags")]
    public string? Tags { get; set; }
}

