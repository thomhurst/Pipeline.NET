using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("webpubsub", "service", "group", "remove-connection")]
public record AzWebpubsubServiceGroupRemoveConnectionOptions(
[property: CommandSwitch("--connection-id")] string ConnectionId,
[property: CommandSwitch("--group-name")] string GroupName,
[property: CommandSwitch("--hub-name")] string HubName
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
}