using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iot", "hub", "policy", "create")]
public record AzIotHubPolicyCreateOptions(
[property: CommandSwitch("--hub-name")] string HubName,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--permissions")] string Permissions
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}