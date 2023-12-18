using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "partner", "namespace", "event-channel")]
public class AzEventgridPartnerNamespaceEventChannelList
{
    public AzEventgridPartnerNamespaceEventChannelList(
        AzEventgridPartnerNamespaceEventChannelListEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridPartnerNamespaceEventChannelListEventgrid Eventgrid { get; }
}