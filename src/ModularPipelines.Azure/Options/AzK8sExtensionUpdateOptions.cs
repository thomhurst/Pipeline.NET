using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("k8s-extension", "update")]
public record AzK8sExtensionUpdateOptions(
[property: CommandSwitch("--cluster-name")] string ClusterName,
[property: CommandSwitch("--cluster-type")] string ClusterType,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [BooleanCommandSwitch("--auto-upgrade")]
    public bool? AutoUpgrade { get; set; }

    [CommandSwitch("--cluster-resource-provider")]
    public string? ClusterResourceProvider { get; set; }

    [CommandSwitch("--config")]
    public string? Config { get; set; }

    [CommandSwitch("--config-file")]
    public string? ConfigFile { get; set; }

    [CommandSwitch("--config-protected")]
    public string? ConfigProtected { get; set; }

    [CommandSwitch("--config-protected-file")]
    public string? ConfigProtectedFile { get; set; }

    [CommandSwitch("--config-settings")]
    public string? ConfigSettings { get; set; }

    [CommandSwitch("--configuration-protected-settings")]
    public string? ConfigurationProtectedSettings { get; set; }

    [CommandSwitch("--configuration-protected-settings-file")]
    public string? ConfigurationProtectedSettingsFile { get; set; }

    [CommandSwitch("--configuration-settings-file")]
    public string? ConfigurationSettingsFile { get; set; }

    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }

    [CommandSwitch("--release-train")]
    public string? ReleaseTrain { get; set; }

    [CommandSwitch("--version")]
    public string? Version { get; set; }

    [BooleanCommandSwitch("--yes")]
    public bool? Yes { get; set; }
}

