using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Google.Options;
using ModularPipelines.Models;

namespace ModularPipelines.Google.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("vmware")]
public class GcloudVmwareNodeTypes
{
    public GcloudVmwareNodeTypes(
        ICommand internalCommand
    )
    {
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public async Task<CommandResult> Describe(GcloudVmwareNodeTypesDescribeOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> List(GcloudVmwareNodeTypesListOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new GcloudVmwareNodeTypesListOptions(), token);
    }
}