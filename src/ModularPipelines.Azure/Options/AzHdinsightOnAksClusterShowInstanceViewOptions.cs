using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("hdinsight-on-aks", "cluster", "show-instance-view")]
public record AzHdinsightOnAksClusterShowInstanceViewOptions : AzOptions
{
    [CommandSwitch("--cluster-name")]
    public string? ClusterName { get; set; }

    [CommandSwitch("--cluster-pool-name")]
    public string? ClusterPoolName { get; set; }

    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}