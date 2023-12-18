using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "table")]
public class AzCosmosdbTableRestorableResource
{
    public AzCosmosdbTableRestorableResource(
        AzCosmosdbTableRestorableResourceList list,
        ICommand internalCommand
    )
    {
        ListCommands = list;
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public AzCosmosdbTableRestorableResourceList ListCommands { get; }

    public async Task<CommandResult> List(AzCosmosdbTableRestorableResourceListOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }
}