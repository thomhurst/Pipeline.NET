using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storagesync", "sync-group", "create")]
public record AzStoragesyncSyncGroupCreateOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--storage-sync-service")] string StorageSyncService
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}