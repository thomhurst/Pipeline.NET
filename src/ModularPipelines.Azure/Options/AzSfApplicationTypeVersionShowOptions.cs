using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sf", "application-type", "version", "show")]
public record AzSfApplicationTypeVersionShowOptions(
[property: CommandSwitch("--application-type-name")] string ApplicationTypeName,
[property: CommandSwitch("--application-type-version")] string ApplicationTypeVersion,
[property: CommandSwitch("--cluster-name")] string ClusterName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
}