using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("compute", "security-policies", "list")]
public record GcloudComputeSecurityPoliciesListOptions(
[property: PositionalArgument] string Name
) : GcloudOptions
{
    [CommandSwitch("--regexp")]
    public string? Regexp { get; set; }

    [BooleanCommandSwitch("--global")]
    public bool? Global { get; set; }

    [CommandSwitch("--regions")]
    public string[]? Regions { get; set; }
}