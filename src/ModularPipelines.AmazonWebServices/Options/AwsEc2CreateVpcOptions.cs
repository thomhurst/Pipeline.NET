using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("ec2", "create-vpc")]
public record AwsEc2CreateVpcOptions : AwsOptions
{
    [CommandSwitch("--cidr-block")]
    public string? CidrBlock { get; set; }

    [CommandSwitch("--ipv6-pool")]
    public string? Ipv6Pool { get; set; }

    [CommandSwitch("--ipv6-cidr-block")]
    public string? Ipv6CidrBlock { get; set; }

    [CommandSwitch("--ipv4-ipam-pool-id")]
    public string? Ipv4IpamPoolId { get; set; }

    [CommandSwitch("--ipv4-netmask-length")]
    public int? Ipv4NetmaskLength { get; set; }

    [CommandSwitch("--ipv6-ipam-pool-id")]
    public string? Ipv6IpamPoolId { get; set; }

    [CommandSwitch("--ipv6-netmask-length")]
    public int? Ipv6NetmaskLength { get; set; }

    [CommandSwitch("--instance-tenancy")]
    public string? InstanceTenancy { get; set; }

    [CommandSwitch("--ipv6-cidr-block-network-border-group")]
    public string? Ipv6CidrBlockNetworkBorderGroup { get; set; }

    [CommandSwitch("--tag-specifications")]
    public string[]? TagSpecifications { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}