using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sql", "server")]
public class AzSqlServerMsSupport
{
    public AzSqlServerMsSupport(
        AzSqlServerMsSupportAuditPolicy auditPolicy
    )
    {
        AuditPolicy = auditPolicy;
    }

    public AzSqlServerMsSupportAuditPolicy AuditPolicy { get; }
}