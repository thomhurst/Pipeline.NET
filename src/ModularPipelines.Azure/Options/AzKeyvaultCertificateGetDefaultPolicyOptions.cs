using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("keyvault", "certificate", "get-default-policy")]
public record AzKeyvaultCertificateGetDefaultPolicyOptions : AzOptions
{
    [BooleanCommandSwitch("--scaffold")]
    public bool? Scaffold { get; set; }
}