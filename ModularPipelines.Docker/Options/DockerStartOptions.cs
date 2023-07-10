﻿using ModularPipelines.Attributes;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("start")]
public record DockerStartOptions(string Container) : DockerOptions
{
    [CommandLongSwitch("attach")]
    public string? Attach { get; set; }

    [CommandLongSwitch("checkpoint")]
    public string? Checkpoint { get; set; }

    [CommandLongSwitch("checkpoint-dir")]
    public string? CheckpointDir { get; set; }

    [CommandLongSwitch("detach-keys")]
    public string? DetachKeys { get; set; }

    [CommandLongSwitch("interactive")]
    public string? Interactive { get; set; }

}