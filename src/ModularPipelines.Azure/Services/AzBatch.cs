using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
public class AzBatch
{
    public AzBatch(
        AzBatchAccount account,
        AzBatchApplication application,
        AzBatchCertificate certificate,
        AzBatchFile file,
        AzBatchJob job,
        AzBatchJobSchedule jobSchedule,
        AzBatchLocation location,
        AzBatchNode node,
        AzBatchPool pool,
        AzBatchPrivateEndpointConnection privateEndpointConnection,
        AzBatchPrivateLinkResource privateLinkResource,
        AzBatchTask task
    )
    {
        Account = account;
        Application = application;
        Certificate = certificate;
        File = file;
        Job = job;
        JobSchedule = jobSchedule;
        Location = location;
        Node = node;
        Pool = pool;
        PrivateEndpointConnection = privateEndpointConnection;
        PrivateLinkResource = privateLinkResource;
        Task = task;
    }

    public AzBatchAccount Account { get; }

    public AzBatchApplication Application { get; }

    public AzBatchCertificate Certificate { get; }

    public AzBatchFile File { get; }

    public AzBatchJob Job { get; }

    public AzBatchJobSchedule JobSchedule { get; }

    public AzBatchLocation Location { get; }

    public AzBatchNode Node { get; }

    public AzBatchPool Pool { get; }

    public AzBatchPrivateEndpointConnection PrivateEndpointConnection { get; }

    public AzBatchPrivateLinkResource PrivateLinkResource { get; }

    public AzBatchTask Task { get; }
}

