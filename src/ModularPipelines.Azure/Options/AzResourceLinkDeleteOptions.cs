using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("resource", "link", "delete")]
public record AzResourceLinkDeleteOptions(
[property: CommandSwitch("--link")] string Link
) : AzOptions
{
    [CommandSwitch("--filter")]
    public string? Filter { get; set; }

    [CommandSwitch("--scope")]
    public string? Scope { get; set; }
}