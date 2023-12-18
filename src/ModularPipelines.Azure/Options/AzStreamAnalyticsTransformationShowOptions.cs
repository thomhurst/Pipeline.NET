using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("stream-analytics", "transformation", "show")]
public record AzStreamAnalyticsTransformationShowOptions(
[property: CommandSwitch("--job-name")] string JobName,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--if-match")]
    public string? IfMatch { get; set; }

    [CommandSwitch("--saql")]
    public string? Saql { get; set; }

    [CommandSwitch("--streaming-units")]
    public string? StreamingUnits { get; set; }

    [CommandSwitch("--valid-streaming-units")]
    public string? ValidStreamingUnits { get; set; }
}