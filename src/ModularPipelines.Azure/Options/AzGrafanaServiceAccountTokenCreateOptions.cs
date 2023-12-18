using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("grafana", "service-account", "token", "create")]
public record AzGrafanaServiceAccountTokenCreateOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--service-account")] int ServiceAccount,
[property: CommandSwitch("--token")] string Token
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--time-to-live")]
    public string? TimeToLive { get; set; }
}