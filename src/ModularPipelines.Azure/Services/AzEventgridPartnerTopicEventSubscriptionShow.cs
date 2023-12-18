using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "partner", "topic", "event-subscription")]
public class AzEventgridPartnerTopicEventSubscriptionShow
{
    public AzEventgridPartnerTopicEventSubscriptionShow(
        AzEventgridPartnerTopicEventSubscriptionShowEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridPartnerTopicEventSubscriptionShowEventgrid Eventgrid { get; }
}