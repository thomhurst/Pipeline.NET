using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("devops", "extension", "uninstall")]
public record AzDevopsExtensionUninstallOptions(
[property: CommandSwitch("--extension-id")] string ExtensionId,
[property: CommandSwitch("--publisher-id")] string PublisherId
) : AzOptions
{
    [BooleanCommandSwitch("--detect")]
    public bool? Detect { get; set; }

    [CommandSwitch("--org")]
    public string? Org { get; set; }

    [BooleanCommandSwitch("--yes")]
    public bool? Yes { get; set; }
}