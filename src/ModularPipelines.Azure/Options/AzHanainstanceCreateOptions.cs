using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("hanainstance", "create")]
public record AzHanainstanceCreateOptions(
[property: CommandSwitch("--instance-name")] string InstanceName,
[property: CommandSwitch("--ip-address")] string IpAddress,
[property: CommandSwitch("--location")] string Location,
[property: CommandSwitch("--os-computer-name")] string OsComputerName,
[property: CommandSwitch("--partner-node-id")] string PartnerNodeId,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--ssh-public-key")] string SshPublicKey
) : AzOptions
{
}