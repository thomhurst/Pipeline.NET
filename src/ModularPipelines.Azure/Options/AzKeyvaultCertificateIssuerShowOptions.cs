using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("keyvault", "certificate", "issuer", "show")]
public record AzKeyvaultCertificateIssuerShowOptions(
[property: CommandSwitch("--issuer-name")] string IssuerName,
[property: CommandSwitch("--vault-name")] string VaultName
) : AzOptions
{
}