using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("edge-cloud", "networking", "subnets", "delete")]
public record GcloudEdgeCloudNetworkingSubnetsDeleteOptions(
[property: PositionalArgument] string Subnet,
[property: PositionalArgument] string Location,
[property: PositionalArgument] string Zone
) : GcloudOptions
{
    [BooleanCommandSwitch("--async")]
    public bool? Async { get; set; }
}