using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "domain", "topic")]
public class AzEventgridDomainTopicDelete
{
    public AzEventgridDomainTopicDelete(
        AzEventgridDomainTopicDeleteEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridDomainTopicDeleteEventgrid Eventgrid { get; }
}