using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("offure", "vmware", "machine", "show")]
public record AzOffazureVmwareMachineShowOptions : AzOptions
{
    [CommandSwitch("--ids")]
    public string? Ids { get; set; }

    [CommandSwitch("--machine-name")]
    public string? MachineName { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--site-name")]
    public string? SiteName { get; set; }

    [CommandSwitch("--subscription")]
    public string? Subscription { get; set; }
}