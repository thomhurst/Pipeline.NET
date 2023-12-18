using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("boards")]
public class AzBoardsIteration
{
    public AzBoardsIteration(
        AzBoardsIterationProject project,
        AzBoardsIterationTeam team
    )
    {
        Project = project;
        Team = team;
    }

    public AzBoardsIterationProject Project { get; }

    public AzBoardsIterationTeam Team { get; }
}