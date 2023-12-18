using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "account", "blob-inventory-policy", "create")]
public record AzStorageAccountBlobInventoryPolicyCreateOptions(
[property: CommandSwitch("--account-name")] int AccountName,
[property: CommandSwitch("--policy")] string Policy
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}