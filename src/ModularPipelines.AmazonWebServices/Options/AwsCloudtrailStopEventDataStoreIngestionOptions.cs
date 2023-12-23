using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cloudtrail", "stop-event-data-store-ingestion")]
public record AwsCloudtrailStopEventDataStoreIngestionOptions(
[property: CommandSwitch("--event-data-store")] string EventDataStore
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}