using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "sql", "role", "assignment", "list")]
public record AzCosmosdbSqlRoleAssignmentListOptions(
[property: CommandSwitch("--account-name")] int AccountName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }

    [CommandSwitch("--principal-id")]
    public string? PrincipalId { get; set; }

    [CommandSwitch("--role-definition-id")]
    public string? RoleDefinitionId { get; set; }

    [CommandSwitch("--role-definition-name")]
    public string? RoleDefinitionName { get; set; }

    [CommandSwitch("--scope")]
    public string? Scope { get; set; }
}