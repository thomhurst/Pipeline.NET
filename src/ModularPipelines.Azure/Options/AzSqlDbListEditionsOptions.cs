using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sql", "db", "list-editions")]
public record AzSqlDbListEditionsOptions(
[property: CommandSwitch("--location")] string Location
) : AzOptions
{
    [BooleanCommandSwitch("--available")]
    public bool? Available { get; set; }

    [CommandSwitch("--dtu")]
    public string? Dtu { get; set; }

    [CommandSwitch("--edition")]
    public string? Edition { get; set; }

    [CommandSwitch("--service-objective")]
    public string? ServiceObjective { get; set; }

    [CommandSwitch("--show-details")]
    public string? ShowDetails { get; set; }

    [CommandSwitch("--vcores")]
    public string? Vcores { get; set; }
}