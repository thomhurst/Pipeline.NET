using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("appservice", "plan", "create", "(appservice-kube", "extension)")]
public record AzAppservicePlanCreateAppserviceKubeExtensionOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--app-service-environment")]
    public string? AppServiceEnvironment { get; set; }

    [CommandSwitch("--custom-location")]
    public string? CustomLocation { get; set; }

    [CommandSwitch("--hyper-v")]
    public string? HyperV { get; set; }

    [CommandSwitch("--is-linux")]
    public string? IsLinux { get; set; }

    [CommandSwitch("--location")]
    public string? Location { get; set; }

    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }

    [CommandSwitch("--number-of-workers")]
    public string? NumberOfWorkers { get; set; }

    [BooleanCommandSwitch("--per-site-scaling")]
    public bool? PerSiteScaling { get; set; }

    [CommandSwitch("--sku")]
    public string? Sku { get; set; }

    [CommandSwitch("--tags")]
    public string? Tags { get; set; }
}

