using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("webapp", "list-runtimes")]
public record AzWebappListRuntimesOptions(
[property: CommandSwitch("--instance-count")] int InstanceCount
) : AzOptions
{
    [BooleanCommandSwitch("--linux")]
    public bool? Linux { get; set; }

    [CommandSwitch("--os")]
    public string? Os { get; set; }
}

