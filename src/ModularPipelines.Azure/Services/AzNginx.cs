using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
public class AzNginx
{
    public AzNginx(
        AzNginxDeployment deployment
    )
    {
        Deployment = deployment;
    }

    public AzNginxDeployment Deployment { get; }
}