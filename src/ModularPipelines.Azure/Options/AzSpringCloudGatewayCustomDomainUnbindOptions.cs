using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("spring-cloud", "gateway", "custom-domain", "unbind")]
public record AzSpringCloudGatewayCustomDomainUnbindOptions(
[property: CommandSwitch("--domain-name")] string DomainName,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--service")] string Service
) : AzOptions
{
    [CommandSwitch("--certificate")]
    public string? Certificate { get; set; }
}