using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iot", "central", "device", "command", "history")]
public record AzIotCentralDeviceCommandHistoryOptions(
[property: CommandSwitch("--app-id")] string AppId,
[property: CommandSwitch("--cn")] string Cn,
[property: CommandSwitch("--device-id")] string DeviceId
) : AzOptions
{
    [CommandSwitch("--api-version")]
    public string? ApiVersion { get; set; }

    [CommandSwitch("--central-api-uri")]
    public string? CentralApiUri { get; set; }

    [CommandSwitch("--co")]
    public string? Co { get; set; }

    [CommandSwitch("--interface-id")]
    public string? InterfaceId { get; set; }

    [CommandSwitch("--mn")]
    public string? Mn { get; set; }

    [CommandSwitch("--token")]
    public string? Token { get; set; }
}