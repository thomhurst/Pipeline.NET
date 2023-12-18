using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network", "manager", "list-effective-security-admin-rule")]
public record AzNetworkManagerListEffectiveSecurityAdminRuleOptions(
[property: CommandSwitch("--commit-type")] string CommitType,
[property: CommandSwitch("--target-locations")] string TargetLocations
) : AzOptions
{
    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--skip-token")]
    public string? SkipToken { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }

    [CommandSwitch("--virtual-network-name")]
    public string? VirtualNetworkName { get; set; }
}