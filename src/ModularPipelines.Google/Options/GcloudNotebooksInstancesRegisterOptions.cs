using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("notebooks", "instances", "register")]
public record GcloudNotebooksInstancesRegisterOptions(
[property: PositionalArgument] string Instance,
[property: PositionalArgument] string Location
) : GcloudOptions
{
    [BooleanCommandSwitch("--async")]
    public bool? Async { get; set; }
}