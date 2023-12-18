using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "partner", "namespace", "key")]
public class AzEventgridPartnerNamespaceKeyRegenerate
{
    public AzEventgridPartnerNamespaceKeyRegenerate(
        AzEventgridPartnerNamespaceKeyRegenerateEventgrid eventgrid
    )
    {
        Eventgrid = eventgrid;
    }

    public AzEventgridPartnerNamespaceKeyRegenerateEventgrid Eventgrid { get; }
}

