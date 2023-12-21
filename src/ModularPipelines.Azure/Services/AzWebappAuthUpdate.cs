using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("webapp", "auth")]
public class AzWebappAuthUpdate
{
    public AzWebappAuthUpdate(
        AzWebappAuthUpdateAuthV2 authV2
    )
    {
        AuthV2 = authV2;
    }

    public AzWebappAuthUpdateAuthV2 AuthV2 { get; }
}