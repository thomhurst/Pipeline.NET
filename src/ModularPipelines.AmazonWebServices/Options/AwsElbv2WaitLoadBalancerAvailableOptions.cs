using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("elbv2", "wait", "load-balancer-available")]
public record AwsElbv2WaitLoadBalancerAvailableOptions : AwsOptions
{
    [CommandSwitch("--load-balancer-arns")]
    public string[]? LoadBalancerArns { get; set; }

    [CommandSwitch("--names")]
    public string[]? Names { get; set; }

    [CommandSwitch("--page-size")]
    public int? PageSize { get; set; }

    [CommandSwitch("--starting-token")]
    public string? StartingToken { get; set; }

    [CommandSwitch("--max-items")]
    public int? MaxItems { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}