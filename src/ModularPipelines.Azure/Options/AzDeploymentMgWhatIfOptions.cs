using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("deployment", "mg", "what-if")]
public record AzDeploymentMgWhatIfOptions(
[property: CommandSwitch("--location")] string Location,
[property: CommandSwitch("--management-group-id")] string ManagementGroupId
) : AzOptions
{
    [CommandSwitch("--exclude-change-types")]
    public string? ExcludeChangeTypes { get; set; }

    [CommandSwitch("--name")]
    public string? Name { get; set; }

    [BooleanCommandSwitch("--no-pretty-print")]
    public bool? NoPrettyPrint { get; set; }

    [BooleanCommandSwitch("--no-prompt")]
    public bool? NoPrompt { get; set; }

    [CommandSwitch("--parameters")]
    public string[]? Parameters { get; set; }

    [CommandSwitch("--query-string")]
    public string? QueryString { get; set; }

    [CommandSwitch("--result-format")]
    public string? ResultFormat { get; set; }

    [CommandSwitch("--template-file")]
    public string? TemplateFile { get; set; }

    [CommandSwitch("--template-spec")]
    public string? TemplateSpec { get; set; }

    [CommandSwitch("--template-uri")]
    public string? TemplateUri { get; set; }
}