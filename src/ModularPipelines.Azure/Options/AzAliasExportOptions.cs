using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("alias", "export")]
public record AzAliasExportOptions : AzOptions
{
    [CommandSwitch("--exclude")]
    public string? Exclude { get; set; }

    [CommandSwitch("--path")]
    public string? Path { get; set; }
}