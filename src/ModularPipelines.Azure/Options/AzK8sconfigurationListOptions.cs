using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("k8sconfiguration", "list")]
public record AzK8sconfigurationListOptions(
[property: CommandSwitch("--cluster-name")] string ClusterName,
[property: CommandSwitch("--cluster-type")] string ClusterType,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [BooleanCommandSwitch("--enable-helm-operator")]
    public bool? EnableHelmOperator { get; set; }

    [CommandSwitch("--helm-operator-params")]
    public string? HelmOperatorParams { get; set; }

    [CommandSwitch("--helm-operator-version")]
    public string? HelmOperatorVersion { get; set; }

    [CommandSwitch("--operator-params")]
    public string? OperatorParams { get; set; }

    [CommandSwitch("--repository-url")]
    public string? RepositoryUrl { get; set; }

    [CommandSwitch("--ssh-known-hosts")]
    public string? SshKnownHosts { get; set; }

    [CommandSwitch("--ssh-known-hosts-file")]
    public string? SshKnownHostsFile { get; set; }
}