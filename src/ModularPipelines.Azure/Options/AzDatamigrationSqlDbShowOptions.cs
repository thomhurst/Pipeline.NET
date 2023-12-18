using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("datamigration", "sql-db", "show")]
public record AzDatamigrationSqlDbShowOptions : AzOptions
{
    [CommandSwitch("--expand")]
    public string? Expand { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--migration-operation-id")]
    public string? MigrationOperationId { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--sqldb-instance-name")]
    public string? SqldbInstanceName { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }

    [CommandSwitch("--target-db-name")]
    public string? TargetDbName { get; set; }
}