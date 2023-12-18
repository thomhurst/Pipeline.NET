using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("billing-benefits", "savings-plan-order", "elevate")]
public record AzBillingBenefitsSavingsPlanOrderElevateOptions(
[property: CommandSwitch("--savings-plan-order-id")] string SavingsPlanOrderId
) : AzOptions
{
    [CommandSwitch("--expand")]
    public string? Expand { get; set; }
}