using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("frauddetector", "delete-detector-version")]
public record AwsFrauddetectorDeleteDetectorVersionOptions(
[property: CommandSwitch("--detector-id")] string DetectorId,
[property: CommandSwitch("--detector-version-id")] string DetectorVersionId
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}