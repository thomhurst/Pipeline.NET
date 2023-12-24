using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cloudwatch", "delete-anomaly-detector")]
public record AwsCloudwatchDeleteAnomalyDetectorOptions : AwsOptions
{
    [CommandSwitch("--namespace")]
    public string? Namespace { get; set; }

    [CommandSwitch("--metric-name")]
    public string? MetricName { get; set; }

    [CommandSwitch("--dimensions")]
    public string[]? Dimensions { get; set; }

    [CommandSwitch("--stat")]
    public string? Stat { get; set; }

    [CommandSwitch("--single-metric-anomaly-detector")]
    public string? SingleMetricAnomalyDetector { get; set; }

    [CommandSwitch("--metric-math-anomaly-detector")]
    public string? MetricMathAnomalyDetector { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}