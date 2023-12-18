using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("dt", "job", "import", "show")]
public record AzDtJobImportShowOptions(
[property: CommandSwitch("--dt-name")] string DtName,
[property: CommandSwitch("--job-id")] string JobId
) : AzOptions
{
    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}