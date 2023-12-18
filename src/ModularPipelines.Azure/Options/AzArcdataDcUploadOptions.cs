using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("arcdata", "dc", "upload")]
public record AzArcdataDcUploadOptions(
[property: CommandSwitch("--path")] string Path
) : AzOptions
{
}

