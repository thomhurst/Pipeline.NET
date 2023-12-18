using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
public class AzPrivateLink
{
    public AzPrivateLink(
        AzPrivateLinkAssociation association
    )
    {
        Association = association;
    }

    public AzPrivateLinkAssociation Association { get; }
}