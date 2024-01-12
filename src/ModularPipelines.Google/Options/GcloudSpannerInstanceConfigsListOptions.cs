using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("spanner", "instance-configs", "list")]
public record GcloudSpannerInstanceConfigsListOptions : GcloudOptions;