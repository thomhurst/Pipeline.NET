using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("nginx", "deployment", "certificate", "show")]
public record AzNginxDeploymentCertificateShowOptions : AzOptions
{
    [CommandSwitch("--certificate-name")]
    public string? CertificateName { get; set; }

    [CommandSwitch("--deployment-name")]
    public string? DeploymentName { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}