using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("identity", "federated-credential", "list")]
public record AzIdentityFederatedCredentialListOptions(
[property: CommandSwitch("--identity-name")] string IdentityName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--audiences")]
    public string? Audiences { get; set; }

    [CommandSwitch("--issuer")]
    public string? Issuer { get; set; }

    [CommandSwitch("--subject")]
    public string? Subject { get; set; }
}