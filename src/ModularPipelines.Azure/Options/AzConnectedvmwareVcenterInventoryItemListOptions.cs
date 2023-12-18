using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("connectedvmware", "vcenter", "inventory-item", "list")]
public record AzConnectedvmwareVcenterInventoryItemListOptions(
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--vcenter")] string Vcenter
) : AzOptions
{
}