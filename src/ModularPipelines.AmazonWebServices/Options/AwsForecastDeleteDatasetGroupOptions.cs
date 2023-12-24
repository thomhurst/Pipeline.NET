using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("forecast", "delete-dataset-group")]
public record AwsForecastDeleteDatasetGroupOptions(
[property: CommandSwitch("--dataset-group-arn")] string DatasetGroupArn
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}