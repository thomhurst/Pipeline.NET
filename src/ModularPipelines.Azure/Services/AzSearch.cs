using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
public class AzSearch
{
    public AzSearch(
        AzSearchAdminKey adminKey,
        AzSearchPrivateEndpointConnection privateEndpointConnection,
        AzSearchPrivateLinkResource privateLinkResource,
        AzSearchQueryKey queryKey,
        AzSearchService service,
        AzSearchSharedPrivateLinkResource sharedPrivateLinkResource
    )
    {
        AdminKey = adminKey;
        PrivateEndpointConnection = privateEndpointConnection;
        PrivateLinkResource = privateLinkResource;
        QueryKey = queryKey;
        Service = service;
        SharedPrivateLinkResource = sharedPrivateLinkResource;
    }

    public AzSearchAdminKey AdminKey { get; }

    public AzSearchPrivateEndpointConnection PrivateEndpointConnection { get; }

    public AzSearchPrivateLinkResource PrivateLinkResource { get; }

    public AzSearchQueryKey QueryKey { get; }

    public AzSearchService Service { get; }

    public AzSearchSharedPrivateLinkResource SharedPrivateLinkResource { get; }
}