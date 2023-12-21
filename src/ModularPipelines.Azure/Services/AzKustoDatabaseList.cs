using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("kusto", "database")]
public class AzKustoDatabaseList
{
    public AzKustoDatabaseList(
        AzKustoDatabaseListKusto kusto
    )
    {
        Kusto = kusto;
    }

    public AzKustoDatabaseListKusto Kusto { get; }
}