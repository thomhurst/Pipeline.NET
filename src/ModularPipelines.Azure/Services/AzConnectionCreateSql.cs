using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("connection", "create")]
public class AzConnectionCreateSql
{
    public AzConnectionCreateSql(
        AzConnectionCreateSqlServiceconnectorPasswordless serviceconnectorPasswordless
    )
    {
        ServiceconnectorPasswordless = serviceconnectorPasswordless;
    }

    public AzConnectionCreateSqlServiceconnectorPasswordless ServiceconnectorPasswordless { get; }
}

