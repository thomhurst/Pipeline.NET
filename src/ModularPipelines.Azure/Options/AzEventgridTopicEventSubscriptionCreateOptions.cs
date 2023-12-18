using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "topic", "event-subscription", "create")]
public record AzEventgridTopicEventSubscriptionCreateOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--topic-name")] string TopicName
) : AzOptions
{
    [CommandSwitch("--aad-app-id")]
    public string? AadAppId { get; set; }

    [CommandSwitch("--aad-tenant-id")]
    public string? AadTenantId { get; set; }

    [CommandSwitch("--advanced-filter")]
    public string? AdvancedFilter { get; set; }

    [CommandSwitch("--deadletter-endpoint")]
    public string? DeadletterEndpoint { get; set; }

    [CommandSwitch("--delivery-attribute-mapping")]
    public string? DeliveryAttributeMapping { get; set; }

    [BooleanCommandSwitch("--enable-advanced-filtering-on-arrays")]
    public bool? EnableAdvancedFilteringOnArrays { get; set; }

    [CommandSwitch("--endpoint")]
    public string? Endpoint { get; set; }

    [CommandSwitch("--endpoint-type")]
    public string? EndpointType { get; set; }

    [CommandSwitch("--event-delivery-schema")]
    public string? EventDeliverySchema { get; set; }

    [CommandSwitch("--event-ttl")]
    public string? EventTtl { get; set; }

    [CommandSwitch("--expiration-date")]
    public string? ExpirationDate { get; set; }

    [CommandSwitch("--included-event-types")]
    public string? IncludedEventTypes { get; set; }

    [CommandSwitch("--labels")]
    public string? Labels { get; set; }

    [CommandSwitch("--max-delivery-attempts")]
    public string? MaxDeliveryAttempts { get; set; }

    [CommandSwitch("--max-events-per-batch")]
    public string? MaxEventsPerBatch { get; set; }

    [CommandSwitch("--pref-batch-size-kb")]
    public string? PrefBatchSizeKb { get; set; }

    [CommandSwitch("--qttl")]
    public string? Qttl { get; set; }

    [CommandSwitch("--subject-begins-with")]
    public string? SubjectBeginsWith { get; set; }

    [BooleanCommandSwitch("--subject-case-sensitive")]
    public bool? SubjectCaseSensitive { get; set; }

    [CommandSwitch("--subject-ends-with")]
    public string? SubjectEndsWith { get; set; }
}