using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("security", "setting", "list")]
public record AzSecuritySettingListOptions(
[property: CommandSwitch("--name")] string Name
) : AzOptions
{
}