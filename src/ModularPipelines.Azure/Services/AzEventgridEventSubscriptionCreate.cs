using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "event-subscription")]
public class AzEventgridEventSubscriptionCreate
{
    public AzEventgridEventSubscriptionCreate(
        AzEventgridEventSubscriptionCreateEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridEventSubscriptionCreateEventgrid Eventgrid { get; }
}