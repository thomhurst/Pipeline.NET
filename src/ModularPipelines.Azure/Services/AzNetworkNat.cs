using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network")]
public class AzNetworkNat
{
    public AzNetworkNat(
        AzNetworkNatGateway gateway
    )
    {
        Gateway = gateway;
    }

    public AzNetworkNatGateway Gateway { get; }
}