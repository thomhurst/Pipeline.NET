using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("containerapp", "connection", "create")]
public class AzContainerappConnectionCreatePostgres
{
    public AzContainerappConnectionCreatePostgres(
        AzContainerappConnectionCreatePostgresServiceconnectorPasswordless serviceconnectorPasswordless
    )
    {
        ServiceconnectorPasswordless = serviceconnectorPasswordless;
    }

    public AzContainerappConnectionCreatePostgresServiceconnectorPasswordless ServiceconnectorPasswordless { get; }
}