using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("staticwebapp", "functions", "link")]
public record AzStaticwebappFunctionsLinkOptions(
[property: CommandSwitch("--function-resource-id")] string FunctionResourceId,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--environment-name")]
    public string? EnvironmentName { get; set; }

    [BooleanCommandSwitch("--force")]
    public bool? Force { get; set; }
}