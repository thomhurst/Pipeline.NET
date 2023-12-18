using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("workloads", "monitor")]
public class AzWorkloadsMonitorProviderInstance
{
    public AzWorkloadsMonitorProviderInstance(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> Create(AzWorkloadsMonitorProviderInstanceCreateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Delete(AzWorkloadsMonitorProviderInstanceDeleteOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> List(AzWorkloadsMonitorProviderInstanceListOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Show(AzWorkloadsMonitorProviderInstanceShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzWorkloadsMonitorProviderInstanceShowOptions(), token);
    }

    public async Task<CommandResult> Wait(AzWorkloadsMonitorProviderInstanceWaitOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzWorkloadsMonitorProviderInstanceWaitOptions(), token);
    }
}

