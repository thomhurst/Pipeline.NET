using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("communication", "identity")]
public class AzCommunicationIdentityUser
{
    public AzCommunicationIdentityUser(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> Create(AzCommunicationIdentityUserCreateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Delete(AzCommunicationIdentityUserDeleteOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }
}