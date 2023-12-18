using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("aks")]
public class AzAksRotateCerts
{
    public AzAksRotateCerts(
        AzAksRotateCertsAksPreview aksPreview
    )
    {
        AksPreview = aksPreview;
    }

    public AzAksRotateCertsAksPreview AksPreview { get; }
}