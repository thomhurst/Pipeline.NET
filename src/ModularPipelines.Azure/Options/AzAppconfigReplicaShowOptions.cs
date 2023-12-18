using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("appconfig", "replica", "show")]
public record AzAppconfigReplicaShowOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--store-name")] string StoreName
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}