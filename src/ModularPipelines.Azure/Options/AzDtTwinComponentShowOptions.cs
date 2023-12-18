using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("dt", "twin", "component", "show")]
public record AzDtTwinComponentShowOptions(
[property: CommandSwitch("--component")] string Component,
[property: CommandSwitch("--dt-name")] string DtName,
[property: CommandSwitch("--twin-id")] string TwinId
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}

