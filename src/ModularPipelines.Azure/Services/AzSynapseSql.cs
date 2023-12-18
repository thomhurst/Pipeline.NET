using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("synapse")]
public class AzSynapseSql
{
    public AzSynapseSql(
        AzSynapseSqlAdAdmin adAdmin,
        AzSynapseSqlAuditPolicy auditPolicy,
        AzSynapseSqlPool pool
    )
    {
        AdAdmin = adAdmin;
        AuditPolicy = auditPolicy;
        Pool = pool;
    }

    public AzSynapseSqlAdAdmin AdAdmin { get; }

    public AzSynapseSqlAuditPolicy AuditPolicy { get; }

    public AzSynapseSqlPool Pool { get; }
}