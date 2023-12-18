using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("partnercenter", "marketplace", "offer", "submission", "list")]
public record AzPartnercenterMarketplaceOfferSubmissionListOptions(
[property: CommandSwitch("--offer-id")] string OfferId
) : AzOptions
{
}

