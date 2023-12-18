using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("netappfiles", "account", "backup-policy", "show")]
public record AzNetappfilesAccountBackupPolicyShowOptions : AzOptions
{
    [CommandSwitch("--account-name")]
    public int? AccountName { get; set; }

    [CommandSwitch("--backup-policy-name")]
    public string? BackupPolicyName { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}