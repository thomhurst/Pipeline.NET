using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("monitor", "autoscale", "show-predictive-metric")]
public record AzMonitorAutoscaleShowPredictiveMetricOptions(
[property: CommandSwitch("--aggregation")] string Aggregation,
[property: CommandSwitch("--interval")] int Interval,
[property: CommandSwitch("--metric-name")] string MetricName,
[property: CommandSwitch("--metric-namespace")] string MetricNamespace,
[property: CommandSwitch("--timespan")] string Timespan
) : AzOptions
{
    [CommandSwitch("--autoscale-setting-name")]
    public string? AutoscaleSettingName { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}

