using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("blockchain", "transaction-node", "list")]
public record AzBlockchainTransactionNodeListOptions(
[property: CommandSwitch("--member-name")] string MemberName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--key-name")]
    public string? KeyName { get; set; }

    [CommandSwitch("--value")]
    public string? Value { get; set; }
}

