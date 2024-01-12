using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("service-directory", "endpoints", "delete")]
public record GcloudServiceDirectoryEndpointsDeleteOptions(
[property: PositionalArgument] string Endpoint,
[property: PositionalArgument] string Location,
[property: PositionalArgument] string Namespace,
[property: PositionalArgument] string Service
) : GcloudOptions;