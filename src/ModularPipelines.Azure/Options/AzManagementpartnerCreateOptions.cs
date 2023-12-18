using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("managementpartner", "create")]
public record AzManagementpartnerCreateOptions(
[property: CommandSwitch("--partner-id")] string PartnerId
) : AzOptions
{
}