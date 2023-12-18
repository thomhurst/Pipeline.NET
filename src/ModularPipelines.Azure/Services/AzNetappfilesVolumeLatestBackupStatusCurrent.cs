using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("netappfiles", "volume", "latest-backup-status")]
public class AzNetappfilesVolumeLatestBackupStatusCurrent
{
    public AzNetappfilesVolumeLatestBackupStatusCurrent(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> Show(AzNetappfilesVolumeLatestBackupStatusCurrentShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzNetappfilesVolumeLatestBackupStatusCurrentShowOptions(), token);
    }
}

