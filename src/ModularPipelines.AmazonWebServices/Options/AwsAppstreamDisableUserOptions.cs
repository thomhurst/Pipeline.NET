using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("appstream", "disable-user")]
public record AwsAppstreamDisableUserOptions(
[property: CommandSwitch("--user-name")] string UserName,
[property: CommandSwitch("--authentication-type")] string AuthenticationType
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}