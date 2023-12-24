using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("docdb", "start-db-cluster")]
public record AwsDocdbStartDbClusterOptions(
[property: CommandSwitch("--db-cluster-identifier")] string DbClusterIdentifier
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}