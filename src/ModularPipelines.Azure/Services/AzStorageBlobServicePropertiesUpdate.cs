using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "blob", "service-properties")]
public class AzStorageBlobServicePropertiesUpdate
{
    public AzStorageBlobServicePropertiesUpdate(
        AzStorageBlobServicePropertiesUpdateStorageBlobPreview storageBlobPreview
    )
    {
        StorageBlobPreview = storageBlobPreview;
    }

    public AzStorageBlobServicePropertiesUpdateStorageBlobPreview StorageBlobPreview { get; }
}

