using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("spring", "gateway", "route-config", "show")]
public record AzSpringGatewayRouteConfigShowOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--service")] string Service
) : AzOptions
{
    [CommandSwitch("--app-name")]
    public string? AppName { get; set; }

    [CommandSwitch("--routes-file")]
    public string? RoutesFile { get; set; }

    [CommandSwitch("--routes-json")]
    public string? RoutesJson { get; set; }
}

