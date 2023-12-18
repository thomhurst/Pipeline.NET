using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("dms", "project", "task")]
public class AzDmsProjectTaskCreate
{
    public AzDmsProjectTaskCreate(
        AzDmsProjectTaskCreateDmsPreview dmsPreview
    )
    {
        DmsPreview = dmsPreview;
    }

    public AzDmsProjectTaskCreateDmsPreview DmsPreview { get; }
}

