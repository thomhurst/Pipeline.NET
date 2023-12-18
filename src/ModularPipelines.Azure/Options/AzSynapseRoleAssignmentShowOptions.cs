using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("synapse", "role", "assignment", "show")]
public record AzSynapseRoleAssignmentShowOptions(
[property: CommandSwitch("--id")] string Id,
[property: CommandSwitch("--workspace-name")] string WorkspaceName
) : AzOptions
{
}