using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("proton", "get-service-template-version")]
public record AwsProtonGetServiceTemplateVersionOptions(
[property: CommandSwitch("--major-version")] string MajorVersion,
[property: CommandSwitch("--minor-version")] string MinorVersion,
[property: CommandSwitch("--template-name")] string TemplateName
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}