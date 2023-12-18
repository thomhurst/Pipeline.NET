using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "file", "metadata")]
public class AzStorageFileMetadataShow
{
    public AzStorageFileMetadataShow(
        AzStorageFileMetadataShowStoragePreview storagePreview
    )
    {
        StoragePreview = storagePreview;
    }

    public AzStorageFileMetadataShowStoragePreview StoragePreview { get; }
}