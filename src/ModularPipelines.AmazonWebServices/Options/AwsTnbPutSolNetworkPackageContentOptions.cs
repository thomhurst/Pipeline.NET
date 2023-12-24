using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("tnb", "put-sol-network-package-content")]
public record AwsTnbPutSolNetworkPackageContentOptions(
[property: CommandSwitch("--file")] string File,
[property: CommandSwitch("--nsd-info-id")] string NsdInfoId
) : AwsOptions
{
    [CommandSwitch("--content-type")]
    public string? ContentType { get; set; }

    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}