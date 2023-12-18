using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network", "front-door", "load-balancing", "create")]
public record AzNetworkFrontDoorLoadBalancingCreateOptions(
[property: CommandSwitch("--front-door-name")] string FrontDoorName,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--sample-size")] string SampleSize,
[property: CommandSwitch("--successful-samples-required")] string SuccessfulSamplesRequired
) : AzOptions
{
    [CommandSwitch("--additional-latency")]
    public string? AdditionalLatency { get; set; }
}