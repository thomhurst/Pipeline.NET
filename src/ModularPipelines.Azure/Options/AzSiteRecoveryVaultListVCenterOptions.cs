using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("site-recovery", "vault", "list-v-center")]
public record AzSiteRecoveryVaultListVCenterOptions(
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--vault-name")] string VaultName
) : AzOptions
{
    [CommandSwitch("--max-items")]
    public string? MaxItems { get; set; }

    [CommandSwitch("--next-token")]
    public string? NextToken { get; set; }
}