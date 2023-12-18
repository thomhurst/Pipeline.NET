using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("acr")]
public class AzAcrManifest
{
    public AzAcrManifest(
        AzAcrManifestMetadata metadata,
        ICommand internalCommand
    )
    {
        Metadata = metadata;
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public AzAcrManifestMetadata Metadata { get; }

    public async Task<CommandResult> Delete(AzAcrManifestDeleteOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestDeleteOptions(), token);
    }

    public async Task<CommandResult> List(AzAcrManifestListOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestListOptions(), token);
    }

    public async Task<CommandResult> ListDeleted(AzAcrManifestListDeletedOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestListDeletedOptions(), token);
    }

    public async Task<CommandResult> ListDeletedTags(AzAcrManifestListDeletedTagsOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestListDeletedTagsOptions(), token);
    }

    public async Task<CommandResult> ListMetadata(AzAcrManifestListMetadataOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestListMetadataOptions(), token);
    }

    public async Task<CommandResult> ListReferrers(AzAcrManifestListReferrersOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestListReferrersOptions(), token);
    }

    public async Task<CommandResult> Restore(AzAcrManifestRestoreOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestRestoreOptions(), token);
    }

    public async Task<CommandResult> Show(AzAcrManifestShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestShowOptions(), token);
    }

    public async Task<CommandResult> ShowMetadata(AzAcrManifestShowMetadataOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestShowMetadataOptions(), token);
    }

    public async Task<CommandResult> UpdateMetadata(AzAcrManifestUpdateMetadataOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzAcrManifestUpdateMetadataOptions(), token);
    }
}

