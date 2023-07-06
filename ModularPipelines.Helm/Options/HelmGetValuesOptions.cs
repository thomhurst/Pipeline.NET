﻿using ModularPipelines.Attributes;

namespace ModularPipelines.Helm.Options;

[CommandPrecedingArguments("get", "values")]
public record HelmGetValuesOptions : HelmOptions
{
    [BooleanCommandSwitch("all")]
    public bool? All { get; set; }

    [CommandLongSwitch("output", SwitchValueSeparator = " ")]
    public string? Output { get; set; }

    [CommandLongSwitch("revision", SwitchValueSeparator = " ")]
    public int? Revision { get; set; }

}
