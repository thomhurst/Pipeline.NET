using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("ams", "account", "encryption", "set")]
public record AzAmsAccountEncryptionSetOptions(
[property: CommandSwitch("--key-type")] string KeyType
) : AzOptions
{
    [CommandSwitch("--account-name")]
    public int? AccountName { get; set; }

    [CommandSwitch("--current-key-id")]
    public string? CurrentKeyId { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--key-identifier")]
    public string? KeyIdentifier { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }

    [BooleanCommandSwitch("--system-assigned")]
    public bool? SystemAssigned { get; set; }

    [CommandSwitch("--user-assigned")]
    public string? UserAssigned { get; set; }
}