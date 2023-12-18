using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("arcdata", "dc", "config", "list")]
public record AzArcdataDcConfigListOptions(
[property: CommandSwitch("--patch-file")] string PatchFile,
[property: CommandSwitch("--path")] string Path
) : AzOptions
{
    [CommandSwitch("--config-profile")]
    public string? ConfigProfile { get; set; }
}