﻿using ModularPipelines.Attributes;

namespace ModularPipelines.Kubernetes.Options;

[CommandPrecedingArguments("alpha")]
public record KubernetesAlphaOptions : KubernetesOptions
{
    [CommandLongSwitch("api-group", SwitchValueSeparator = " ")]
    public string? ApiGroup { get; set; }

    [BooleanCommandSwitch("cached")]
    public bool? Cached { get; set; }

    [BooleanCommandSwitch("namespaced")]
    public bool? Namespaced { get; set; }

    [BooleanCommandSwitch("no-headers")]
    public bool? NoHeaders { get; set; }

    [CommandLongSwitch("output", SwitchValueSeparator = " ")]
    public string? Output { get; set; }

    [CommandLongSwitch("sort-by", SwitchValueSeparator = " ")]
    public string? SortBy { get; set; }

    [CommandLongSwitch("verbs", SwitchValueSeparator = " ")]
    public string[]? Verbs { get; set; }

}
