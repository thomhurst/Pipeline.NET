using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("greengrass", "stop-bulk-deployment")]
public record AwsGreengrassStopBulkDeploymentOptions(
[property: CommandSwitch("--bulk-deployment-id")] string BulkDeploymentId
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}