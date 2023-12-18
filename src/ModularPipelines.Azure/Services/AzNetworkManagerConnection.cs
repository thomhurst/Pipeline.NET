using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("network", "manager")]
public class AzNetworkManagerConnection
{
    public AzNetworkManagerConnection(
        AzNetworkManagerConnectionManagementGroup managementGroup,
        AzNetworkManagerConnectionSubscription subscription
    )
    {
        ManagementGroup = managementGroup;
        Subscription = subscription;
    }

    public AzNetworkManagerConnectionManagementGroup ManagementGroup { get; }

    public AzNetworkManagerConnectionSubscription Subscription { get; }
}