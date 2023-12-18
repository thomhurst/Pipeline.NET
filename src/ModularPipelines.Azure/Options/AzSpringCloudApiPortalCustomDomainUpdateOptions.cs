using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("spring-cloud", "api-portal", "custom-domain", "update")]
public record AzSpringCloudApiPortalCustomDomainUpdateOptions(
[property: CommandSwitch("--domain-name")] string DomainName,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--service")] string Service
) : AzOptions
{
    [CommandSwitch("--certificate")]
    public string? Certificate { get; set; }
}