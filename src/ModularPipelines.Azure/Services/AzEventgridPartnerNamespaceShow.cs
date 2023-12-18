using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "partner", "namespace")]
public class AzEventgridPartnerNamespaceShow
{
    public AzEventgridPartnerNamespaceShow(
        AzEventgridPartnerNamespaceShowEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridPartnerNamespaceShowEventgrid Eventgrid { get; }
}