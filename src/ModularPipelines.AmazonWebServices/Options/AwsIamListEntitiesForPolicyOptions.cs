using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iam", "list-entities-for-policy")]
public record AwsIamListEntitiesForPolicyOptions(
[property: CommandSwitch("--policy-arn")] string PolicyArn
) : AwsOptions
{
    [CommandSwitch("--entity-filter")]
    public string? EntityFilter { get; set; }

    [CommandSwitch("--path-prefix")]
    public string? PathPrefix { get; set; }

    [CommandSwitch("--policy-usage-filter")]
    public string? PolicyUsageFilter { get; set; }

    [CommandSwitch("--max-items")]
    public int? MaxItems { get; set; }

    [CommandSwitch("--starting-token")]
    public string? StartingToken { get; set; }

    [CommandSwitch("--page-size")]
    public int? PageSize { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}