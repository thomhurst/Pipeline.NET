using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "container", "immutability-policy", "delete")]
public record AzStorageContainerImmutabilityPolicyDeleteOptions(
[property: CommandSwitch("--account-name")] int AccountName,
[property: CommandSwitch("--container-name")] string ContainerName,
[property: CommandSwitch("--if-match")] string IfMatch
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}