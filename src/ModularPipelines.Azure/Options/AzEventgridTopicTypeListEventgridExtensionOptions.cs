using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("eventgrid", "topic-type", "list", "(eventgrid", "extension)")]
public record AzEventgridTopicTypeListEventgridExtensionOptions(
[property: CommandSwitch("--name")] string Name
) : AzOptions
{
}