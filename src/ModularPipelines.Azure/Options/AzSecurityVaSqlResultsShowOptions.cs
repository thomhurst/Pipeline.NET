using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("security", "va", "sql", "results", "show")]
public record AzSecurityVaSqlResultsShowOptions(
[property: CommandSwitch("--database-name")] string DatabaseName,
[property: CommandSwitch("--rule-id")] string RuleId,
[property: CommandSwitch("--scan-id")] string ScanId,
[property: CommandSwitch("--server-name")] string ServerName,
[property: CommandSwitch("--vm-resource-id")] string VmResourceId,
[property: CommandSwitch("--workspace-id")] string WorkspaceId
) : AzOptions
{
    [CommandSwitch("--agent-id")]
    public string? AgentId { get; set; }

    [CommandSwitch("--vm-name")]
    public string? VmName { get; set; }

    [CommandSwitch("--vm-uuid")]
    public string? VmUuid { get; set; }
}