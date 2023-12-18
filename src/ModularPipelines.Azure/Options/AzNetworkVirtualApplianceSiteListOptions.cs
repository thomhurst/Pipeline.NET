using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network", "virtual-appliance", "site", "list")]
public record AzNetworkVirtualApplianceSiteListOptions(
[property: CommandSwitch("--appliance-name")] string ApplianceName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
}