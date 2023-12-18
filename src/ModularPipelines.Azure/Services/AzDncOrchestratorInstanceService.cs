using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("dnc")]
public class AzDncOrchestratorInstanceService
{
    public AzDncOrchestratorInstanceService(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> Create(AzDncOrchestratorInstanceServiceCreateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Delete(AzDncOrchestratorInstanceServiceDeleteOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzDncOrchestratorInstanceServiceDeleteOptions(), token);
    }

    public async Task<CommandResult> Show(AzDncOrchestratorInstanceServiceShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzDncOrchestratorInstanceServiceShowOptions(), token);
    }

    public async Task<CommandResult> Wait(AzDncOrchestratorInstanceServiceWaitOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzDncOrchestratorInstanceServiceWaitOptions(), token);
    }
}