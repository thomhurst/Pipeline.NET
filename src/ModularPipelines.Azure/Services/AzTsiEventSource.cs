using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("tsi")]
public class AzTsiEventSource
{
    public AzTsiEventSource(
        AzTsiEventSourceEventhub eventhub,
        AzTsiEventSourceIothub iothub,
        ICommand internalCommand
    )
    {
        Eventhub = eventhub;
        Iothub = iothub;
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public AzTsiEventSourceEventhub Eventhub { get; }

    public AzTsiEventSourceIothub Iothub { get; }

    public async Task<CommandResult> Delete(AzTsiEventSourceDeleteOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> List(AzTsiEventSourceListOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Show(AzTsiEventSourceShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzTsiEventSourceShowOptions(), token);
    }
}