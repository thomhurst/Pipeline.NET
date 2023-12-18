using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("vm", "secret", "format")]
public record AzVmSecretFormatOptions(
[property: CommandSwitch("--secrets")] string Secrets
) : AzOptions
{
    [CommandSwitch("--certificate-store")]
    public string? CertificateStore { get; set; }

    [CommandSwitch("--keyvault")]
    public string? Keyvault { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}