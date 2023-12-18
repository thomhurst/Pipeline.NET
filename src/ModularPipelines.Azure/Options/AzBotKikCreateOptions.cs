using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("bot", "kik", "create")]
public record AzBotKikCreateOptions(
[property: CommandSwitch("--key")] string Key,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--resource-group")] string ResourceGroup,
[property: CommandSwitch("--user-name")] string UserName
) : AzOptions
{
    [BooleanCommandSwitch("--add-disabled")]
    public bool? AddDisabled { get; set; }

    [BooleanCommandSwitch("--is-validated")]
    public bool? IsValidated { get; set; }

    [CommandSwitch("--location")]
    public string? Location { get; set; }
}