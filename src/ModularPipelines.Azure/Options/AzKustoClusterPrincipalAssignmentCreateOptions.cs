using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("kusto", "cluster-principal-assignment", "create")]
public record AzKustoClusterPrincipalAssignmentCreateOptions(
[property: CommandSwitch("--cluster-name")] string ClusterName,
[property: CommandSwitch("--principal-assignment-name")] string PrincipalAssignmentName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }

    [CommandSwitch("--principal-id")]
    public string? PrincipalId { get; set; }

    [CommandSwitch("--principal-type")]
    public string? PrincipalType { get; set; }

    [CommandSwitch("--role")]
    public string? Role { get; set; }

    [CommandSwitch("--tenant-id")]
    public string? TenantId { get; set; }
}

