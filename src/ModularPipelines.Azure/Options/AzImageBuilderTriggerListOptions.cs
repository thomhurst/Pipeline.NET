using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("image", "builder", "trigger", "list")]
public record AzImageBuilderTriggerListOptions(
[property: CommandSwitch("--image-template-name")] string ImageTemplateName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
}