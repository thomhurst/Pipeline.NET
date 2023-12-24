using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iotwireless", "get-wireless-gateway")]
public record AwsIotwirelessGetWirelessGatewayOptions(
[property: CommandSwitch("--identifier")] string Identifier,
[property: CommandSwitch("--identifier-type")] string IdentifierType
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}