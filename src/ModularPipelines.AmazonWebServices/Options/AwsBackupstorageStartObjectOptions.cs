using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("backupstorage", "start-object")]
public record AwsBackupstorageStartObjectOptions(
[property: CommandSwitch("--backup-job-id")] string BackupJobId,
[property: CommandSwitch("--object-name")] string ObjectName
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}