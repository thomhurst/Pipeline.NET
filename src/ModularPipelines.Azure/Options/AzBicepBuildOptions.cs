using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("bicep", "build")]
public record AzBicepBuildOptions(
[property: CommandSwitch("--file")] string File
) : AzOptions
{
    [BooleanCommandSwitch("--no-restore")]
    public bool? NoRestore { get; set; }

    [CommandSwitch("--outdir")]
    public string? Outdir { get; set; }

    [CommandSwitch("--outfile")]
    public string? Outfile { get; set; }

    [CommandSwitch("--stdout")]
    public string? Stdout { get; set; }
}