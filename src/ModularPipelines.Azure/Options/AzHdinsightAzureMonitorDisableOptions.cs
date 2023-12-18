using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("hdinsight", "ure-monitor", "disable")]
public record AzHdinsightAzureMonitorDisableOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [BooleanCommandSwitch("--no-validation-timeout")]
    public bool? NoValidationTimeout { get; set; }

    [CommandSwitch("--primary-key")]
    public string? PrimaryKey { get; set; }
}