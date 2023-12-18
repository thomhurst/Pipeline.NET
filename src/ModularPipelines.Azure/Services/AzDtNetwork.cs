using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("dt")]
public class AzDtNetwork
{
    public AzDtNetwork(
        AzDtNetworkPrivateEndpoint privateEndpoint,
        AzDtNetworkPrivateLink privateLink
    )
    {
        PrivateEndpoint = privateEndpoint;
        PrivateLink = privateLink;
    }

    public AzDtNetworkPrivateEndpoint PrivateEndpoint { get; }

    public AzDtNetworkPrivateLink PrivateLink { get; }
}

