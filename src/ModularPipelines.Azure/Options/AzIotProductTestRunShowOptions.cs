using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iot", "product", "test", "run", "show")]
public record AzIotProductTestRunShowOptions(
[property: CommandSwitch("--test-id")] string TestId
) : AzOptions
{
    [CommandSwitch("--base-url")]
    public string? BaseUrl { get; set; }

    [CommandSwitch("--interval")]
    public int? Interval { get; set; }

    [CommandSwitch("--run-id")]
    public string? RunId { get; set; }

    [BooleanCommandSwitch("--wait")]
    public bool? Wait { get; set; }
}