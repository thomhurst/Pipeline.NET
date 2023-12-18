using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("account", "subscription", "enable")]
public record AzAccountSubscriptionEnableOptions(
[property: CommandSwitch("--id")] string Id
) : AzOptions
{
}