using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sf", "managed-application-type", "version", "create")]
public record AzSfManagedApplicationTypeVersionCreateOptions(
[property: CommandSwitch("--application-type-name")] string ApplicationTypeName,
[property: CommandSwitch("--application-type-version")] string ApplicationTypeVersion,
[property: CommandSwitch("--cluster-name")] string ClusterName,
[property: CommandSwitch("--package-url")] string PackageUrl,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--tags")]
    public string? Tags { get; set; }
}

