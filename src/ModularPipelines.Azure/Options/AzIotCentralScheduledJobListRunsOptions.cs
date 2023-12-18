using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iot", "central", "scheduled-job", "list-runs")]
public record AzIotCentralScheduledJobListRunsOptions(
[property: CommandSwitch("--app-id")] string AppId,
[property: CommandSwitch("--id")] string Id
) : AzOptions
{
    [CommandSwitch("--central-api-uri")]
    public string? CentralApiUri { get; set; }

    [CommandSwitch("--token")]
    public string? Token { get; set; }
}