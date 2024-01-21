using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Models;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("image")]
[ExcludeFromCodeCoverage]
public record DockerImageOptions : DockerOptions
{
}
