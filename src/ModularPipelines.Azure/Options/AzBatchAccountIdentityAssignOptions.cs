using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("batch", "account", "identity", "assign")]
public record AzBatchAccountIdentityAssignOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--system-assigned")]
    public string? SystemAssigned { get; set; }

    [CommandSwitch("--user-assigned")]
    public string? UserAssigned { get; set; }
}