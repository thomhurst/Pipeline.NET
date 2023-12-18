using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("ssh", "cert")]
public record AzSshCertOptions : AzOptions
{
    [CommandSwitch("--file")]
    public string? File { get; set; }

    [CommandSwitch("--public-key-file")]
    public string? PublicKeyFile { get; set; }

    [CommandSwitch("--ssh-client-folder")]
    public string? SshClientFolder { get; set; }
}