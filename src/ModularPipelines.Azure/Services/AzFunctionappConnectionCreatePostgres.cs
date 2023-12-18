using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("functionapp", "connection", "create")]
public class AzFunctionappConnectionCreatePostgres
{
    public AzFunctionappConnectionCreatePostgres(
        AzFunctionappConnectionCreatePostgresServiceconnectorPasswordless serviceconnectorPasswordless
    )
    {
        ServiceconnectorPasswordless = serviceconnectorPasswordless;
    }

    public AzFunctionappConnectionCreatePostgresServiceconnectorPasswordless ServiceconnectorPasswordless { get; }
}