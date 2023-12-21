using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

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