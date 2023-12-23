using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("vpc-lattice", "delete-rule")]
public record AwsVpcLatticeDeleteRuleOptions(
[property: CommandSwitch("--listener-identifier")] string ListenerIdentifier,
[property: CommandSwitch("--rule-identifier")] string RuleIdentifier,
[property: CommandSwitch("--service-identifier")] string ServiceIdentifier
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}