using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("repos", "pr", "work-item", "remove")]
public record AzReposPrWorkItemRemoveOptions(
[property: CommandSwitch("--id")] string Id,
[property: CommandSwitch("--work-items")] string WorkItems
) : AzOptions
{
    [BooleanCommandSwitch("--detect")]
    public bool? Detect { get; set; }

    [CommandSwitch("--org")]
    public string? Org { get; set; }
}

