using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("group", "list")]
public record AzGroupListOptions : AzOptions
{
    [CommandSwitch("--tag")]
    public string? Tag { get; set; }
}