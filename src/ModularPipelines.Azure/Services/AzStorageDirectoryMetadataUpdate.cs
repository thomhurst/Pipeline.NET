using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "directory", "metadata")]
public class AzStorageDirectoryMetadataUpdate
{
    public AzStorageDirectoryMetadataUpdate(
        AzStorageDirectoryMetadataUpdateStoragePreview storagePreview
    )
    {
        StoragePreview = storagePreview;
    }

    public AzStorageDirectoryMetadataUpdateStoragePreview StoragePreview { get; }
}