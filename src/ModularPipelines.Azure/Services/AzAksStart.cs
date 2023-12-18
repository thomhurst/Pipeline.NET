using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("aks")]
public class AzAksStart
{
    public AzAksStart(
        AzAksStartAksPreview aksPreview
    )
    {
        AksPreview = aksPreview;
    }

    public AzAksStartAksPreview AksPreview { get; }
}