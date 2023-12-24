using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("inspector2", "list-coverage-statistics")]
public record AwsInspector2ListCoverageStatisticsOptions : AwsOptions
{
    [CommandSwitch("--filter-criteria")]
    public string? FilterCriteria { get; set; }

    [CommandSwitch("--group-by")]
    public string? GroupBy { get; set; }

    [CommandSwitch("--starting-token")]
    public string? StartingToken { get; set; }

    [CommandSwitch("--max-items")]
    public int? MaxItems { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}