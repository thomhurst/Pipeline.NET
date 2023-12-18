using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sentinel", "incident", "run-playbook")]
public record AzSentinelIncidentRunPlaybookOptions(
[property: CommandSwitch("--incident-identifier")] string IncidentIdentifier,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--workspace-name")] string WorkspaceName
) : AzOptions
{
    [CommandSwitch("--logic-apps-resource-id")]
    public string? LogicAppsResourceId { get; set; }

    [CommandSwitch("--tenant-id")]
    public string? TenantId { get; set; }
}

