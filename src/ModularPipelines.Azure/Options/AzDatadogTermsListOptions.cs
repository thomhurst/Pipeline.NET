using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("datadog", "terms", "list")]
public record AzDatadogTermsListOptions : AzOptions
{
    [CommandSwitch("--properties")]
    public string? Properties { get; set; }
}