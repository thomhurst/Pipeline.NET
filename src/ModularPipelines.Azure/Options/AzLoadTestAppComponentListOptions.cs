using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("load", "test", "app-component", "list")]
public record AzLoadTestAppComponentListOptions(
[property: CommandSwitch("--load-test-resource")] string LoadTestResource,
[property: CommandSwitch("--test-id")] string TestId
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}