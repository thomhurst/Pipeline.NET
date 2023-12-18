using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("monitor", "log-analytics", "query-pack")]
public class AzMonitorLogAnalyticsQueryPackQuery
{
    public AzMonitorLogAnalyticsQueryPackQuery(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> Create(AzMonitorLogAnalyticsQueryPackQueryCreateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Delete(AzMonitorLogAnalyticsQueryPackQueryDeleteOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> List(AzMonitorLogAnalyticsQueryPackQueryListOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Search(AzMonitorLogAnalyticsQueryPackQuerySearchOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzMonitorLogAnalyticsQueryPackQuerySearchOptions(), token);
    }

    public async Task<CommandResult> Show(AzMonitorLogAnalyticsQueryPackQueryShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzMonitorLogAnalyticsQueryPackQueryShowOptions(), token);
    }

    public async Task<CommandResult> Update(AzMonitorLogAnalyticsQueryPackQueryUpdateOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzMonitorLogAnalyticsQueryPackQueryUpdateOptions(), token);
    }
}

