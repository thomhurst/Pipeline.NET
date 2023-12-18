using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("communication", "sms", "send-sms")]
public record AzCommunicationSmsSendSmsOptions(
[property: CommandSwitch("--message")] string Message,
[property: CommandSwitch("--recipient")] string Recipient,
[property: CommandSwitch("--sender")] string Sender
) : AzOptions
{
    [CommandSwitch("--connection-string")]
    public string? ConnectionString { get; set; }
}