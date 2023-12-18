using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("aks", "trustedaccess", "role", "list")]
public record AzAksTrustedaccessRoleListOptions(
[property: CommandSwitch("--location")] string Location
) : AzOptions
{
}