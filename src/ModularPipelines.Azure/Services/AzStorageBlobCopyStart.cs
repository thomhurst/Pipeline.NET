using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "blob", "copy")]
public class AzStorageBlobCopyStart
{
    public AzStorageBlobCopyStart(
        AzStorageBlobCopyStartStorageBlobPreview storageBlobPreview
    )
    {
        StorageBlobPreview = storageBlobPreview;
    }

    public AzStorageBlobCopyStartStorageBlobPreview StorageBlobPreview { get; }
}