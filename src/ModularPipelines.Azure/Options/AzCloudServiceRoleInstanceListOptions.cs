using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cloud-service", "role-instance", "list")]
public record AzCloudServiceRoleInstanceListOptions(
[property: CommandSwitch("--cloud-service-name")] string CloudServiceName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
}