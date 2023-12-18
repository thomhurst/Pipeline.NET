using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "file")]
public class AzStorageFileResize
{
    public AzStorageFileResize(
        AzStorageFileResizeStoragePreview storagePreview
    )
    {
        StoragePreview = storagePreview;
    }

    public AzStorageFileResizeStoragePreview StoragePreview { get; }
}