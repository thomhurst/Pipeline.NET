using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("route53resolver", "disassociate-resolver-query-log-config")]
public record AwsRoute53resolverDisassociateResolverQueryLogConfigOptions(
[property: CommandSwitch("--resolver-query-log-config-id")] string ResolverQueryLogConfigId,
[property: CommandSwitch("--resource-id")] string ResourceId
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}