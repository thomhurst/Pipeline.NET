using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("vpc-lattice", "get-access-log-subscription")]
public record AwsVpcLatticeGetAccessLogSubscriptionOptions(
[property: CommandSwitch("--access-log-subscription-identifier")] string AccessLogSubscriptionIdentifier
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}