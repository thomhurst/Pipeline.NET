using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("clouddirectory", "get-directory")]
public record AwsClouddirectoryGetDirectoryOptions(
[property: CommandSwitch("--directory-arn")] string DirectoryArn
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}