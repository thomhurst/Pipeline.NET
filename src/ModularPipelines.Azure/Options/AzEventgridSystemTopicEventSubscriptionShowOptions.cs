using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "system-topic", "event-subscription", "show")]
public record AzEventgridSystemTopicEventSubscriptionShowOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--system-topic-name")] string SystemTopicName
) : AzOptions
{
    [BooleanCommandSwitch("--include-attrib-secret")]
    public bool? IncludeAttribSecret { get; set; }

    [BooleanCommandSwitch("--include-full-endpoint-url")]
    public bool? IncludeFullEndpointUrl { get; set; }
}