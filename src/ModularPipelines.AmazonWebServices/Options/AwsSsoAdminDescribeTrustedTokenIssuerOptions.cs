using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sso-admin", "describe-trusted-token-issuer")]
public record AwsSsoAdminDescribeTrustedTokenIssuerOptions(
[property: CommandSwitch("--trusted-token-issuer-arn")] string TrustedTokenIssuerArn
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}