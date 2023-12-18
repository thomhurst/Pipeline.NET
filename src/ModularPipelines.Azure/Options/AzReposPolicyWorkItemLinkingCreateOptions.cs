using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("repos", "policy", "work-item-linking", "create")]
public record AzReposPolicyWorkItemLinkingCreateOptions(
[property: BooleanCommandSwitch("--blocking")] bool Blocking,
[property: CommandSwitch("--branch")] string Branch,
[property: BooleanCommandSwitch("--enabled")] bool Enabled,
[property: CommandSwitch("--repository-id")] string RepositoryId
) : AzOptions
{
    [CommandSwitch("--branch-match-type")]
    public string? BranchMatchType { get; set; }

    [BooleanCommandSwitch("--detect")]
    public bool? Detect { get; set; }

    [CommandSwitch("--org")]
    public string? Org { get; set; }

    [CommandSwitch("--project")]
    public string? Project { get; set; }
}