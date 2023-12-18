using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("synapse", "kusto", "pool-principal-assignment", "list")]
public record AzSynapseKustoPoolPrincipalAssignmentListOptions(
[property: CommandSwitch("--kusto-pool-name")] string KustoPoolName,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--workspace-name")] string WorkspaceName
) : AzOptions
{
    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--principal-assignment-name")]
    public string? PrincipalAssignmentName { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}