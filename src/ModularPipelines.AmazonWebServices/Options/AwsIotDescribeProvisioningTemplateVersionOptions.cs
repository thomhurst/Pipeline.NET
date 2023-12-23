using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iot", "describe-provisioning-template-version")]
public record AwsIotDescribeProvisioningTemplateVersionOptions(
[property: CommandSwitch("--template-name")] string TemplateName,
[property: CommandSwitch("--version-id")] int VersionId
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}