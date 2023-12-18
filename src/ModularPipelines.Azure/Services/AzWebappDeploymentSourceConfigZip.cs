using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("webapp", "deployment", "source")]
public class AzWebappDeploymentSourceConfigZip
{
    public AzWebappDeploymentSourceConfigZip(
        AzWebappDeploymentSourceConfigZipAppserviceKube appserviceKube
    )
    {
        AppserviceKube = appserviceKube;
    }

    public AzWebappDeploymentSourceConfigZipAppserviceKube AppserviceKube { get; }
}