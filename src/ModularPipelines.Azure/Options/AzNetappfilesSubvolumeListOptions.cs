using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("netappfiles", "subvolume", "list")]
public record AzNetappfilesSubvolumeListOptions(
[property: CommandSwitch("--account-name")] int AccountName,
[property: CommandSwitch("--pool-name")] string PoolName,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--volume-name")] string VolumeName
) : AzOptions
{
}