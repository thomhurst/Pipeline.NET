using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iot", "dps")]
public class AzIotDpsEnrollment
{
    public AzIotDpsEnrollment(
        AzIotDpsEnrollmentRegistration registration,
        ICommand internalCommand
    )
    {
        Registration = registration;
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public AzIotDpsEnrollmentRegistration Registration { get; }

    public async Task<CommandResult> Create(AzIotDpsEnrollmentCreateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Delete(AzIotDpsEnrollmentDeleteOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> List(AzIotDpsEnrollmentListOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Show(AzIotDpsEnrollmentShowOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Update(AzIotDpsEnrollmentUpdateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }
}

