using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "file")]
public class AzStorageFileDownload
{
    public AzStorageFileDownload(
        AzStorageFileDownloadStoragePreview storagePreview
    )
    {
        StoragePreview = storagePreview;
    }

    public AzStorageFileDownloadStoragePreview StoragePreview { get; }
}