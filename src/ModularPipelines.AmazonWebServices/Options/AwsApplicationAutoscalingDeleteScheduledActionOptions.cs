using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("application-autoscaling", "delete-scheduled-action")]
public record AwsApplicationAutoscalingDeleteScheduledActionOptions(
[property: CommandSwitch("--service-namespace")] string ServiceNamespace,
[property: CommandSwitch("--scheduled-action-name")] string ScheduledActionName,
[property: CommandSwitch("--resource-id")] string ResourceId,
[property: CommandSwitch("--scalable-dimension")] string ScalableDimension
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}