using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("proton", "wait", "environment-template-version-registered")]
public record AwsProtonWaitEnvironmentTemplateVersionRegisteredOptions(
[property: CommandSwitch("--major-version")] string MajorVersion,
[property: CommandSwitch("--minor-version")] string MinorVersion,
[property: CommandSwitch("--template-name")] string TemplateName
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}