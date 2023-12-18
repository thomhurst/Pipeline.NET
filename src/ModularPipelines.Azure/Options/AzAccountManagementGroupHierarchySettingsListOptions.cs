using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("account", "management-group", "hierarchy-settings", "list")]
public record AzAccountManagementGroupHierarchySettingsListOptions(
[property: CommandSwitch("--name")] string Name
) : AzOptions
{
    [CommandSwitch("--add")]
    public string? Add { get; set; }

    [CommandSwitch("--default-management-group")]
    public string? DefaultManagementGroup { get; set; }

    [BooleanCommandSwitch("--force-string")]
    public bool? ForceString { get; set; }

    [CommandSwitch("--remove")]
    public string? Remove { get; set; }

    [CommandSwitch("--require-authorization-for-group-creation")]
    public string? RequireAuthorizationForGroupCreation { get; set; }

    [CommandSwitch("--set")]
    public string? Set { get; set; }
}