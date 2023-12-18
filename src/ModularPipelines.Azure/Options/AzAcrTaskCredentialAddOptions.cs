using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("acr", "task", "credential", "add")]
public record AzAcrTaskCredentialAddOptions(
[property: CommandSwitch("--login-server")] string LoginServer,
[property: CommandSwitch("--name")] string Name,
[property: CommandSwitch("--registry")] string Registry
) : AzOptions
{
    [CommandSwitch("--password")]
    public string? Password { get; set; }

    [CommandSwitch("--resource-group")]
    public string? ResourceGroup { get; set; }

    [CommandSwitch("--use-identity")]
    public string? UseIdentity { get; set; }

    [CommandSwitch("--username")]
    public string? Username { get; set; }
}