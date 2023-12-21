using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
public class AzStack
{
    public AzStack(
        AzStackGroup group,
        AzStackMg mg,
        AzStackSub sub
    )
    {
        Group = group;
        Mg = mg;
        Sub = sub;
    }

    public AzStackGroup Group { get; }

    public AzStackMg Mg { get; }

    public AzStackSub Sub { get; }
}