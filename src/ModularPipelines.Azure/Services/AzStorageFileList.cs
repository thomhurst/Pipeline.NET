using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "file")]
public class AzStorageFileList
{
    public AzStorageFileList(
        AzStorageFileListStoragePreview storagePreview
    )
    {
        StoragePreview = storagePreview;
    }

    public AzStorageFileListStoragePreview StoragePreview { get; }
}