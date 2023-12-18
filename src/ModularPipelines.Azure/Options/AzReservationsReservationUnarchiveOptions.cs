using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("reservations", "reservation", "unarchive")]
public record AzReservationsReservationUnarchiveOptions(
[property: CommandSwitch("--reservation-id")] string ReservationId,
[property: CommandSwitch("--reservation-order-id")] string ReservationOrderId
) : AzOptions
{
    [CommandSwitch("--applied-scope-property")]
    public string? AppliedScopeProperty { get; set; }

    [CommandSwitch("--applied-scope-type")]
    public string? AppliedScopeType { get; set; }

    [CommandSwitch("--applied-scopes")]
    public string? AppliedScopes { get; set; }

    [CommandSwitch("--instance-flexibility")]
    public string? InstanceFlexibility { get; set; }

    [CommandSwitch("--name")]
    public string? Name { get; set; }

    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }

    [BooleanCommandSwitch("--renew")]
    public bool? Renew { get; set; }

    [CommandSwitch("--renewal-properties")]
    public string? RenewalProperties { get; set; }
}