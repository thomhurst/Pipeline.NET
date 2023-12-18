using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("boards", "work-item", "relation", "remove")]
public record AzBoardsWorkItemRelationRemoveOptions(
[property: CommandSwitch("--id")] string Id,
[property: CommandSwitch("--relation-type")] string RelationType,
[property: CommandSwitch("--target-id")] string TargetId
) : AzOptions
{
    [BooleanCommandSwitch("--detect")]
    public bool? Detect { get; set; }

    [CommandSwitch("--org")]
    public string? Org { get; set; }

    [BooleanCommandSwitch("--yes")]
    public bool? Yes { get; set; }
}