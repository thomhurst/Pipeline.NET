using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "share")]
public class AzStorageShareCloseHandle
{
    public AzStorageShareCloseHandle(
        AzStorageShareCloseHandleStoragePreview storagePreview
    )
    {
        StoragePreview = storagePreview;
    }

    public AzStorageShareCloseHandleStoragePreview StoragePreview { get; }
}

