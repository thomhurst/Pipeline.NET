using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("boards", "area", "team", "update")]
public record AzBoardsAreaTeamUpdateOptions(
[property: CommandSwitch("--path")] string Path,
[property: CommandSwitch("--team")] string Team
) : AzOptions
{
    [BooleanCommandSwitch("--detect")]
    public bool? Detect { get; set; }

    [BooleanCommandSwitch("--include-sub-areas")]
    public bool? IncludeSubAreas { get; set; }

    [CommandSwitch("--org")]
    public string? Org { get; set; }

    [CommandSwitch("--project")]
    public string? Project { get; set; }

    [BooleanCommandSwitch("--set-as-default")]
    public bool? SetAsDefault { get; set; }
}

