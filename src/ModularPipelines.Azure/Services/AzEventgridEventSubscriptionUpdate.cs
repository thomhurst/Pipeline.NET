using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "event-subscription")]
public class AzEventgridEventSubscriptionUpdate
{
    public AzEventgridEventSubscriptionUpdate(
        AzEventgridEventSubscriptionUpdateEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridEventSubscriptionUpdateEventgrid Eventgrid { get; }
}

