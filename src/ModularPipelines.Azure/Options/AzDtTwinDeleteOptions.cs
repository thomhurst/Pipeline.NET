using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("dt", "twin", "delete")]
public record AzDtTwinDeleteOptions(
[property: CommandSwitch("--dt-name")] string DtName,
[property: CommandSwitch("--twin-id")] string TwinId
) : AzOptions
{
    [CommandSwitch("--etag")]
    public string? Etag { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }
}

