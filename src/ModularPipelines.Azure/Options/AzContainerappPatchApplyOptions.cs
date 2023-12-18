using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("containerapp", "patch", "apply")]
public record AzContainerappPatchApplyOptions : AzOptions
{
    [CommandSwitch("--environment")]
    public string? Environment { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [BooleanCommandSwitch("--show-all")]
    public bool? ShowAll { get; set; }
}