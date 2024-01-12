using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Google.Options;
using ModularPipelines.Models;

namespace ModularPipelines.Google.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("compute", "public-delegated-prefixes")]
public class GcloudComputePublicDelegatedPrefixesDelegatedSubPrefixes
{
    public GcloudComputePublicDelegatedPrefixesDelegatedSubPrefixes(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> Create(GcloudComputePublicDelegatedPrefixesDelegatedSubPrefixesCreateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Delete(GcloudComputePublicDelegatedPrefixesDelegatedSubPrefixesDeleteOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }
}