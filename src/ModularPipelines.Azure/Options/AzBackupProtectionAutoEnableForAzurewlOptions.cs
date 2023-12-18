using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("backup", "protection", "auto-enable-for-urewl")]
public record AzBackupProtectionAutoEnableForAzurewlOptions(
[property: CommandSwitch("--policy-name")] string PolicyName,
[property: CommandSwitch("--protectable-item-name")] string ProtectableItemName,
[property: CommandSwitch("--protectable-item-type")] string ProtectableItemType,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--server-name")] string ServerName,
[property: CommandSwitch("--vault-name")] string VaultName,
[property: CommandSwitch("--workload-type")] string WorkloadType
) : AzOptions
{
}