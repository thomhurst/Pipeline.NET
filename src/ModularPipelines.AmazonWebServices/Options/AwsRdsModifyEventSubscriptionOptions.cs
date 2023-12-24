using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("rds", "modify-event-subscription")]
public record AwsRdsModifyEventSubscriptionOptions(
[property: CommandSwitch("--subscription-name")] string SubscriptionName
) : AwsOptions
{
    [CommandSwitch("--sns-topic-arn")]
    public string? SnsTopicArn { get; set; }

    [CommandSwitch("--source-type")]
    public string? SourceType { get; set; }

    [CommandSwitch("--event-categories")]
    public string[]? EventCategories { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}