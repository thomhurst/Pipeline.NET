using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "topic")]
public class AzEventgridTopicList
{
    public AzEventgridTopicList(
        AzEventgridTopicListEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridTopicListEventgrid Eventgrid { get; }
}