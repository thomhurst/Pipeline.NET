using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("resource", "link", "update")]
public record AzResourceLinkUpdateOptions(
[property: CommandSwitch("--link")] string Link
) : AzOptions
{
    [CommandSwitch("--notes")]
    public string? Notes { get; set; }

    [CommandSwitch("--target")]
    public string? Target { get; set; }
}