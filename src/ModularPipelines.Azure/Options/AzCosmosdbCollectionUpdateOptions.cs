using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "collection", "update")]
public record AzCosmosdbCollectionUpdateOptions(
[property: CommandSwitch("--collection-name")] string CollectionName,
[property: CommandSwitch("--db-name")] string DbName
) : AzOptions
{
    [CommandSwitch("--default-ttl")]
    public string? DefaultTtl { get; set; }

    [CommandSwitch("--indexing-policy")]
    public string? IndexingPolicy { get; set; }

    [CommandSwitch("--key")]
    public string? Key { get; set; }

    [CommandSwitch("--name")]
    public string? Name { get; set; }

    [CommandSwitch("--resource-group-name")]
    public string? ResourceGroupName { get; set; }

    [CommandSwitch("--throughput")]
    public string? Throughput { get; set; }

    [CommandSwitch("--url-connection")]
    public string? UrlConnection { get; set; }
}