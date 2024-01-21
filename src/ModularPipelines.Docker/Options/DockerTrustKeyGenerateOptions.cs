using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Models;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("trust", "key", "generate")]
[ExcludeFromCodeCoverage]
public record DockerTrustKeyGenerateOptions : DockerOptions
{
    [CommandSwitch("--dir")]
    public string? Dir { get; set; }
}
