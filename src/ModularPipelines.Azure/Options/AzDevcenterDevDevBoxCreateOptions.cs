using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("devcenter", "dev", "dev-box", "create")]
public record AzDevcenterDevDevBoxCreateOptions(
[property: CommandSwitch("--dev-box-name")] string DevBoxName,
[property: CommandSwitch("--pool")] string Pool,
[property: CommandSwitch("--project")] string Project
) : AzOptions
{
    [CommandSwitch("--dev-center")]
    public string? DevCenter { get; set; }

    [CommandSwitch("--endpoint")]
    public string? Endpoint { get; set; }

    [BooleanCommandSwitch("--no-wait")]
    public bool? NoWait { get; set; }

    [CommandSwitch("--user-id")]
    public string? UserId { get; set; }
}