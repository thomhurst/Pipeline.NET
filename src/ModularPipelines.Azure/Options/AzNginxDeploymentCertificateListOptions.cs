using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("nginx", "deployment", "certificate", "list")]
public record AzNginxDeploymentCertificateListOptions(
[property: CommandSwitch("--deployment-name")] string DeploymentName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--certificate-name")]
    public string? CertificateName { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}

