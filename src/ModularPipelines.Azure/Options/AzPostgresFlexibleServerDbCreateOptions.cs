using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("postgres", "flexible-server", "db", "create")]
public record AzPostgresFlexibleServerDbCreateOptions(
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--server-name")] string ServerName
) : AzOptions
{
    [CommandSwitch("--charset")]
    public string? Charset { get; set; }

    [CommandSwitch("--collation")]
    public string? Collation { get; set; }

    [CommandSwitch("--database-name")]
    public string? DatabaseName { get; set; }
}

