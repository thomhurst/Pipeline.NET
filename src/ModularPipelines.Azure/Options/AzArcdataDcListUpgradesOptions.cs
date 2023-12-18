using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("arcdata", "dc", "list-upgrades")]
public record AzArcdataDcListUpgradesOptions(
[property: CommandSwitch("--k8s-namespace")] string K8sNamespace
) : AzOptions
{
    [BooleanCommandSwitch("--use-k8s")]
    public bool? UseK8s { get; set; }
}