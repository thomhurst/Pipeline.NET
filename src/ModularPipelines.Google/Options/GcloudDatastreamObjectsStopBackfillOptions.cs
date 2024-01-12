using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("datastream", "objects", "stop-backfill")]
public record GcloudDatastreamObjectsStopBackfillOptions(
[property: PositionalArgument] string Object,
[property: PositionalArgument] string Location,
[property: PositionalArgument] string Stream
) : GcloudOptions;