using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "system-topic", "event-subscription")]
public class AzEventgridSystemTopicEventSubscriptionShow
{
    public AzEventgridSystemTopicEventSubscriptionShow(
        AzEventgridSystemTopicEventSubscriptionShowEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridSystemTopicEventSubscriptionShowEventgrid Eventgrid { get; }
}

