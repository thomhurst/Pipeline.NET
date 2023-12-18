using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
public class AzLargeStorageInstance
{
    public AzLargeStorageInstance(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> List(AzLargeStorageInstanceListOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzLargeStorageInstanceListOptions(), token);
    }

    public async Task<CommandResult> Show(AzLargeStorageInstanceShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzLargeStorageInstanceShowOptions(), token);
    }

    public async Task<CommandResult> Update(AzLargeStorageInstanceUpdateOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzLargeStorageInstanceUpdateOptions(), token);
    }
}