using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("automation", "software-update-configuration", "show")]
public record AzAutomationSoftwareUpdateConfigurationShowOptions(
[property: CommandSwitch("--automation-account-name")] int AutomationAccountName,
[property: CommandSwitch("--configuration-name")] string ConfigurationName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
}