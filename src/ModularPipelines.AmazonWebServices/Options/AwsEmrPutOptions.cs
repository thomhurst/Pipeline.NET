using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("emr", "put")]
public record AwsEmrPutOptions(
[property: CommandSwitch("--cluster-id")] string ClusterId,
[property: CommandSwitch("--key-pair-file")] string KeyPairFile,
[property: CommandSwitch("--src")] string Src
) : AwsOptions
{
    [CommandSwitch("--dest")]
    public string? Dest { get; set; }
}