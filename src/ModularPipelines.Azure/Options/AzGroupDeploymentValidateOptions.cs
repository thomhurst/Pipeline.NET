using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("group", "deployment", "validate")]
public record AzGroupDeploymentValidateOptions(
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--handle-extended-json-format")]
    public string? HandleExtendedJsonFormat { get; set; }

    [CommandSwitch("--mode")]
    public string? Mode { get; set; }

    [BooleanCommandSwitch("--no-prompt")]
    public bool? NoPrompt { get; set; }

    [CommandSwitch("--parameters")]
    public string[]? Parameters { get; set; }

    [CommandSwitch("--rollback-on-error")]
    public string? RollbackOnError { get; set; }

    [CommandSwitch("--template-file")]
    public string? TemplateFile { get; set; }

    [CommandSwitch("--template-uri")]
    public string? TemplateUri { get; set; }
}

