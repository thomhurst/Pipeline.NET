using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("orbital")]
public class AzOrbitalAvailableGroundStation
{
    public AzOrbitalAvailableGroundStation(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> List(AzOrbitalAvailableGroundStationListOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzOrbitalAvailableGroundStationListOptions(), token);
    }

    public async Task<CommandResult> Show(AzOrbitalAvailableGroundStationShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzOrbitalAvailableGroundStationShowOptions(), token);
    }
}

