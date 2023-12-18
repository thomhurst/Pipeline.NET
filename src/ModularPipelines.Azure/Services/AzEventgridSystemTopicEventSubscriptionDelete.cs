using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "system-topic", "event-subscription")]
public class AzEventgridSystemTopicEventSubscriptionDelete
{
    public AzEventgridSystemTopicEventSubscriptionDelete(
        AzEventgridSystemTopicEventSubscriptionDeleteEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridSystemTopicEventSubscriptionDeleteEventgrid Eventgrid { get; }
}