using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("netappfiles", "volume")]
public class AzNetappfilesVolumeCreate
{
    public AzNetappfilesVolumeCreate(
        AzNetappfilesVolumeCreateNetappfilesPreview netappfilesPreview
    )
    {
        NetappfilesPreview = netappfilesPreview;
    }

    public AzNetappfilesVolumeCreateNetappfilesPreview NetappfilesPreview { get; }
}