using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "partner", "namespace", "event-channel", "create")]
public record AzEventgridPartnerNamespaceEventChannelCreateOptions(
[property: CommandSwitch("--destination-rg")] string DestinationRg,
[property: CommandSwitch("--destination-sub-id")] string DestinationSubId,
[property: CommandSwitch("--destination-topic-name")] string DestinationTopicName,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--partner-namespace-name")] string PartnerNamespaceName,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--source")] string Source
) : AzOptions
{
    [CommandSwitch("--activation-expiration-date")]
    public string? ActivationExpirationDate { get; set; }

    [CommandSwitch("--partner-topic-description")]
    public string? PartnerTopicDescription { get; set; }

    [CommandSwitch("--publisher-filter")]
    public string? PublisherFilter { get; set; }
}

