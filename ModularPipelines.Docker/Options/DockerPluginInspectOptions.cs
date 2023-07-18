﻿using ModularPipelines.Attributes;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("plugin inspect")]
public record DockerPluginInspectOptions([property: PositionalArgument(Position = Position.AfterArguments)] IEnumerable<string> Plugins) : DockerOptions
{
    [CommandSwitch("--format")]
    public string? Format { get; set; }
}