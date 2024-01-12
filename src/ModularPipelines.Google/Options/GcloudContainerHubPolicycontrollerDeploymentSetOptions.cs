using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("container", "hub", "policycontroller", "deployment", "set")]
public record GcloudContainerHubPolicycontrollerDeploymentSetOptions(
[property: PositionalArgument] string Deployment,
[property: PositionalArgument] string Property,
[property: PositionalArgument] string Value
) : GcloudOptions
{
    [CommandSwitch("--effect")]
    public string? Effect { get; set; }

    [BooleanCommandSwitch("--all-memberships")]
    public bool? AllMemberships { get; set; }

    [CommandSwitch("--memberships")]
    public string[]? Memberships { get; set; }

    [CommandSwitch("--location")]
    public string? Location { get; set; }
}