using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("apim", "deletedservice", "show")]
public record AzApimDeletedserviceShowOptions(
[property: CommandSwitch("--location")] string Location,
[property: CommandSwitch("--service-name")] string ServiceName
) : AzOptions
{
}