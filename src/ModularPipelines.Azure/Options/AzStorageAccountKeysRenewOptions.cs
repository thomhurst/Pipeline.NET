using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "account", "keys", "renew")]
public record AzStorageAccountKeysRenewOptions(
[property: CommandSwitch("--account-name")] int AccountName,
[property: CommandSwitch("--key")] string Key
) : AzOptions
{
    [CommandSwitch("--key-type")]
    public string? KeyType { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}