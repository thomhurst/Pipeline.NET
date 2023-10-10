﻿using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Node.Models;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("profile")]
public record NpmProfileOptions : NpmOptions
{
    [CommandSwitch("--registry")]
    public Uri? Registry { get; set; }

    [BooleanCommandSwitch("--json")]
    public bool? Json { get; set; }

    [BooleanCommandSwitch("--parseable")]
    public bool? Parseable { get; set; }

    [CommandSwitch("--otp")]
    public string? Otp { get; set; }

}