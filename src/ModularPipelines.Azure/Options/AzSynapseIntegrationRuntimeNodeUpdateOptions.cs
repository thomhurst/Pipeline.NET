using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("synapse", "integration-runtime-node", "update")]
public record AzSynapseIntegrationRuntimeNodeUpdateOptions(
[property: CommandSwitch("--auto-update")] string AutoUpdate,
[property: CommandSwitch("--node-name")] string NodeName,
[property: CommandSwitch("--update-delay-offset")] string UpdateDelayOffset
) : AzOptions
{
    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--name")]
    public string? Name { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }

    [CommandSwitch("--workspace-name")]
    public string? WorkspaceName { get; set; }
}