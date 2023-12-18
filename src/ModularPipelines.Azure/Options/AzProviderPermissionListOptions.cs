using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("provider", "permission", "list")]
public record AzProviderPermissionListOptions(
[property: CommandSwitch("--namespace")] string Namespace
) : AzOptions
{
}