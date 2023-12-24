using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("connect", "describe-prompt")]
public record AwsConnectDescribePromptOptions(
[property: CommandSwitch("--instance-id")] string InstanceId,
[property: CommandSwitch("--prompt-id")] string PromptId
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}