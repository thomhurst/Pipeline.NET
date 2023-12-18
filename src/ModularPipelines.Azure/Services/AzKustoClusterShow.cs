using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("kusto", "cluster")]
public class AzKustoClusterShow
{
    public AzKustoClusterShow(
        AzKustoClusterShowKusto kusto
    )
    {
        Kusto = kusto;
    }

    public AzKustoClusterShowKusto Kusto { get; }
}