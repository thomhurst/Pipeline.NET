using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("network inspect")]
[ExcludeFromCodeCoverage]
public record DockerNetworkInspectOptions([property: PositionalArgument(Position = Position.AfterArguments)] IEnumerable<string> Networks) : DockerOptions
{
    [CommandSwitch("--format")]
    public string? Format { get; set; }

    [CommandSwitch("--verbose")]
    public string? Verbose { get; set; }
}
