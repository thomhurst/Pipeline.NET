using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("group", "create")]
public record AzGroupCreateOptions(
[property: CommandSwitch("--location")] string Location,
[property: CommandSwitch("--name")] string Name
) : AzOptions
{
    [CommandSwitch("--managed-by")]
    public string? ManagedBy { get; set; }

    [CommandSwitch("--tags")]
    public string? Tags { get; set; }
}