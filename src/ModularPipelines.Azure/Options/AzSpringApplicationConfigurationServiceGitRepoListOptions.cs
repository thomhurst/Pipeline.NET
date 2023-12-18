using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("spring", "application-configuration-service", "git", "repo", "list")]
public record AzSpringApplicationConfigurationServiceGitRepoListOptions(
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--service")] string Service
) : AzOptions
{
    [CommandSwitch("--ca-cert-name")]
    public string? CaCertName { get; set; }

    [CommandSwitch("--host-key")]
    public string? HostKey { get; set; }

    [CommandSwitch("--host-key-algorithm")]
    public string? HostKeyAlgorithm { get; set; }

    [CommandSwitch("--host-key-check")]
    public string? HostKeyCheck { get; set; }

    [CommandSwitch("--label")]
    public string? Label { get; set; }

    [CommandSwitch("--password")]
    public string? Password { get; set; }

    [CommandSwitch("--patterns")]
    public string? Patterns { get; set; }

    [CommandSwitch("--private-key")]
    public string? PrivateKey { get; set; }

    [CommandSwitch("--search-paths")]
    public string? SearchPaths { get; set; }

    [CommandSwitch("--uri")]
    public string? Uri { get; set; }

    [CommandSwitch("--username")]
    public string? Username { get; set; }
}