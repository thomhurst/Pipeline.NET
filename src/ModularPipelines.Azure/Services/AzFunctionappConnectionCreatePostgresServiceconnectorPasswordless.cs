using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("functionapp", "connection", "create", "postgres")]
public class AzFunctionappConnectionCreatePostgresServiceconnectorPasswordless
{
    public AzFunctionappConnectionCreatePostgresServiceconnectorPasswordless(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> Extension(AzFunctionappConnectionCreatePostgresServiceconnectorPasswordlessExtensionOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzFunctionappConnectionCreatePostgresServiceconnectorPasswordlessExtensionOptions(), token);
    }
}