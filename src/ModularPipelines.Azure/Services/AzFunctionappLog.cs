using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("functionapp")]
public class AzFunctionappLog
{
    public AzFunctionappLog(
        AzFunctionappLogDeployment deployment
    )
    {
        Deployment = deployment;
    }

    public AzFunctionappLogDeployment Deployment { get; }
}