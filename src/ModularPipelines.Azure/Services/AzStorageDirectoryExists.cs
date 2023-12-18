using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "directory")]
public class AzStorageDirectoryExists
{
    public AzStorageDirectoryExists(
        AzStorageDirectoryExistsStoragePreview storagePreview
    )
    {
        StoragePreview = storagePreview;
    }

    public AzStorageDirectoryExistsStoragePreview StoragePreview { get; }
}