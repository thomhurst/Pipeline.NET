using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("repos", "ref", "unlock")]
public record AzReposRefUnlockOptions(
[property: CommandSwitch("--name")] string Name
) : AzOptions
{
    [BooleanCommandSwitch("--detect")]
    public bool? Detect { get; set; }

    [CommandSwitch("--org")]
    public string? Org { get; set; }

    [CommandSwitch("--project")]
    public string? Project { get; set; }

    [CommandSwitch("--repository")]
    public string? Repository { get; set; }
}