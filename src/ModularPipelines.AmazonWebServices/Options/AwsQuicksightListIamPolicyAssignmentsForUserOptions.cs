using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("quicksight", "list-iam-policy-assignments-for-user")]
public record AwsQuicksightListIamPolicyAssignmentsForUserOptions(
[property: CommandSwitch("--aws-account-id")] string AwsAccountId,
[property: CommandSwitch("--user-name")] string UserName,
[property: CommandSwitch("--namespace")] string Namespace
) : AwsOptions
{
    [CommandSwitch("--starting-token")]
    public string? StartingToken { get; set; }

    [CommandSwitch("--page-size")]
    public int? PageSize { get; set; }

    [CommandSwitch("--max-items")]
    public int? MaxItems { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}