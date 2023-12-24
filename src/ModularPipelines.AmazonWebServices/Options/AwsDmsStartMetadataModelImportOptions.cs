using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("dms", "start-metadata-model-import")]
public record AwsDmsStartMetadataModelImportOptions(
[property: CommandSwitch("--migration-project-identifier")] string MigrationProjectIdentifier,
[property: CommandSwitch("--selection-rules")] string SelectionRules,
[property: CommandSwitch("--origin")] string Origin
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}