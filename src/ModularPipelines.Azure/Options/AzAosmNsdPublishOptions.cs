using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("aosm", "nsd", "publish")]
public record AzAosmNsdPublishOptions(
[property: CommandSwitch("--config-file")] string ConfigFile
) : AzOptions
{
    [CommandSwitch("--design-file")]
    public string? DesignFile { get; set; }

    [CommandSwitch("--manifest-file")]
    public string? ManifestFile { get; set; }

    [CommandSwitch("--manifest-params-file")]
    public string? ManifestParamsFile { get; set; }

    [CommandSwitch("--parameters-json-file")]
    public string? ParametersJsonFile { get; set; }

    [CommandSwitch("--skip")]
    public string? Skip { get; set; }
}