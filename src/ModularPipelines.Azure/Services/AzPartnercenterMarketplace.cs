using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("partnercenter")]
public class AzPartnercenterMarketplace
{
    public AzPartnercenterMarketplace(
        AzPartnercenterMarketplaceOffer offer
    )
    {
        Offer = offer;
    }

    public AzPartnercenterMarketplaceOffer Offer { get; }
}

