using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("compute", "target-http-proxies", "import")]
public record GcloudComputeTargetHttpProxiesImportOptions(
[property: PositionalArgument] string Name
) : GcloudOptions
{
    [CommandSwitch("--source")]
    public string? Source { get; set; }

    [BooleanCommandSwitch("--global")]
    public bool? Global { get; set; }

    [CommandSwitch("--region")]
    public string? Region { get; set; }
}