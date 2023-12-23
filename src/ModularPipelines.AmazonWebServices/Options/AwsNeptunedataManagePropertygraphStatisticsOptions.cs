using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("neptunedata", "manage-propertygraph-statistics")]
public record AwsNeptunedataManagePropertygraphStatisticsOptions : AwsOptions
{
    [CommandSwitch("--mode")]
    public string? Mode { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}