using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("devops")]
public class AzDevopsSecurity
{
    public AzDevopsSecurity(
        AzDevopsSecurityGroup group,
        AzDevopsSecurityPermission permission
    )
    {
        Group = group;
        Permission = permission;
    }

    public AzDevopsSecurityGroup Group { get; }

    public AzDevopsSecurityPermission Permission { get; }
}