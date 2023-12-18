using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sentinel", "source-control", "list")]
public record AzSentinelSourceControlListOptions(
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--workspace-name")] string WorkspaceName
) : AzOptions
{
}