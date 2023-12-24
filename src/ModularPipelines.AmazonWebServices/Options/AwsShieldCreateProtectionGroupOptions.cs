using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("shield", "create-protection-group")]
public record AwsShieldCreateProtectionGroupOptions(
[property: CommandSwitch("--protection-group-id")] string ProtectionGroupId,
[property: CommandSwitch("--aggregation")] string Aggregation,
[property: CommandSwitch("--pattern")] string Pattern
) : AwsOptions
{
    [CommandSwitch("--resource-type")]
    public string? ResourceType { get; set; }

    [CommandSwitch("--members")]
    public string[]? Members { get; set; }

    [CommandSwitch("--tags")]
    public string[]? Tags { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}