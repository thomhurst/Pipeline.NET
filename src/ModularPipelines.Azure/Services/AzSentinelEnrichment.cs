using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sentinel")]
public class AzSentinelEnrichment
{
    public AzSentinelEnrichment(
        AzSentinelEnrichmentDomainWhois domainWhois,
        AzSentinelEnrichmentIpGeodata ipGeodata
    )
    {
        DomainWhois = domainWhois;
        IpGeodata = ipGeodata;
    }

    public AzSentinelEnrichmentDomainWhois DomainWhois { get; }

    public AzSentinelEnrichmentIpGeodata IpGeodata { get; }
}