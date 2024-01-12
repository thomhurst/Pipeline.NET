using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("dataplex", "tasks", "jobs", "cancel")]
public record GcloudDataplexTasksJobsCancelOptions(
[property: PositionalArgument] string Job,
[property: PositionalArgument] string Lake,
[property: PositionalArgument] string Location,
[property: PositionalArgument] string Task
) : GcloudOptions;