using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network", "application-gateway", "private-link", "ip-config", "list")]
public record AzNetworkApplicationGatewayPrivateLinkIpConfigListOptions(
[property: CommandSwitch("--gateway-name")] string GatewayName,
[property: CommandSwitch("--private-link")] string PrivateLink,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
}