using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("cosmosdb", "mongocluster")]
public class AzCosmosdbMongoclusterFirewall
{
    public AzCosmosdbMongoclusterFirewall(
        AzCosmosdbMongoclusterFirewallRule rule
    )
    {
        Rule = rule;
    }

    public AzCosmosdbMongoclusterFirewallRule Rule { get; }
}