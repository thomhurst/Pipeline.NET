using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "topic-type")]
public class AzEventgridTopicTypeListEventTypes
{
    public AzEventgridTopicTypeListEventTypes(
        AzEventgridTopicTypeListEventTypesEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridTopicTypeListEventTypesEventgrid Eventgrid { get; }
}