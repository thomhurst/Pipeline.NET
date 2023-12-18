using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("orbital")]
public class AzOrbitalSpacecraft
{
    public AzOrbitalSpacecraft(
        AzOrbitalSpacecraftContact contact,
        ICommand internalCommand
    )
    {
        Contact = contact;
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public AzOrbitalSpacecraftContact Contact { get; }

    public async Task<CommandResult> Create(AzOrbitalSpacecraftCreateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Delete(AzOrbitalSpacecraftDeleteOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> List(AzOrbitalSpacecraftListOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> ListAvailableContact(AzOrbitalSpacecraftListAvailableContactOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Show(AzOrbitalSpacecraftShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzOrbitalSpacecraftShowOptions(), token);
    }

    public async Task<CommandResult> Update(AzOrbitalSpacecraftUpdateOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzOrbitalSpacecraftUpdateOptions(), token);
    }

    public async Task<CommandResult> Wait(AzOrbitalSpacecraftWaitOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzOrbitalSpacecraftWaitOptions(), token);
    }
}