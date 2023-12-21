using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
public class AzPartnercenter
{
    public AzPartnercenter(
        AzPartnercenterMarketplace marketplace
    )
    {
        Marketplace = marketplace;
    }

    public AzPartnercenterMarketplace Marketplace { get; }
}