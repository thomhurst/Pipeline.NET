using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("bot", "authsetting", "show")]
public record AzBotAuthsettingShowOptions(
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--setting-name")] string SettingName
) : AzOptions
{
}