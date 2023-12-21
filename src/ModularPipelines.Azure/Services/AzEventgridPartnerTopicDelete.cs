using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "partner", "topic")]
public class AzEventgridPartnerTopicDelete
{
    public AzEventgridPartnerTopicDelete(
        AzEventgridPartnerTopicDeleteEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridPartnerTopicDeleteEventgrid Eventgrid { get; }
}