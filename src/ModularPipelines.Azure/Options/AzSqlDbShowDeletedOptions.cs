using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sql", "db", "show-deleted")]
public record AzSqlDbShowDeletedOptions(
[property: CommandSwitch("--restorable-dropped-database-id")] string RestorableDroppedDatabaseId
) : AzOptions
{
    [BooleanCommandSwitch("--expand-keys")]
    public bool? ExpandKeys { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--keys-filter")]
    public string? KeysFilter { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--server")]
    public string? Server { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}