using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("peering", "service", "delete")]
public record AzPeeringServiceDeleteOptions(
[property: CommandSwitch("--peering-service-name")] string PeeringServiceName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
}

