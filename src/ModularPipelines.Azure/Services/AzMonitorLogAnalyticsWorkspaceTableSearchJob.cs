using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("monitor", "log-analytics", "workspace", "table")]
public class AzMonitorLogAnalyticsWorkspaceTableSearchJob
{
    public AzMonitorLogAnalyticsWorkspaceTableSearchJob(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> Cancel(AzMonitorLogAnalyticsWorkspaceTableSearchJobCancelOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Create(AzMonitorLogAnalyticsWorkspaceTableSearchJobCreateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }
}