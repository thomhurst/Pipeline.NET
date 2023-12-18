using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("security", "contact", "delete")]
public record AzSecurityContactDeleteOptions(
[property: CommandSwitch("--name")] string Name
) : AzOptions
{
}