using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("backup", "describe-recovery-point")]
public record AwsBackupDescribeRecoveryPointOptions(
[property: CommandSwitch("--backup-vault-name")] string BackupVaultName,
[property: CommandSwitch("--recovery-point-arn")] string RecoveryPointArn
) : AwsOptions
{
    [CommandSwitch("--backup-vault-account-id")]
    public string? BackupVaultAccountId { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}