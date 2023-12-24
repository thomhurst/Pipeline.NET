using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("configservice", "describe-delivery-channel-status")]
public record AwsConfigserviceDescribeDeliveryChannelStatusOptions : AwsOptions
{
    [CommandSwitch("--delivery-channel-names")]
    public string[]? DeliveryChannelNames { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}