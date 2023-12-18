using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("storage", "file", "upload")]
public record AzStorageFileUploadOptions(
[property: CommandSwitch("--source")] string Source
) : AzOptions
{
    [CommandSwitch("--account-key")]
    public int? AccountKey { get; set; }

    [CommandSwitch("--account-name")]
    public int? AccountName { get; set; }

    [CommandSwitch("--auth-mode")]
    public string? AuthMode { get; set; }

    [BooleanCommandSwitch("--backup-intent")]
    public bool? BackupIntent { get; set; }

    [CommandSwitch("--connection-string")]
    public string? ConnectionString { get; set; }

    [CommandSwitch("--content-cache")]
    public string? ContentCache { get; set; }

    [CommandSwitch("--content-disposition")]
    public string? ContentDisposition { get; set; }

    [CommandSwitch("--content-encoding")]
    public string? ContentEncoding { get; set; }

    [CommandSwitch("--content-language")]
    public string? ContentLanguage { get; set; }

    [CommandSwitch("--content-md5")]
    public string? ContentMd5 { get; set; }

    [CommandSwitch("--content-type")]
    public string? ContentType { get; set; }

    [BooleanCommandSwitch("--disallow-trailing-dot")]
    public bool? DisallowTrailingDot { get; set; }

    [CommandSwitch("--file-endpoint")]
    public string? FileEndpoint { get; set; }

    [CommandSwitch("--file-url")]
    public string? FileUrl { get; set; }

    [CommandSwitch("--max-connections")]
    public string? MaxConnections { get; set; }

    [CommandSwitch("--metadata")]
    public string? Metadata { get; set; }

    [BooleanCommandSwitch("--no-progress")]
    public bool? NoProgress { get; set; }

    [CommandSwitch("--path")]
    public string? Path { get; set; }

    [CommandSwitch("--sas-token")]
    public string? SasToken { get; set; }

    [CommandSwitch("--share-name")]
    public string? ShareName { get; set; }

    [CommandSwitch("--timeout")]
    public string? Timeout { get; set; }

    [BooleanCommandSwitch("--validate-content")]
    public bool? ValidateContent { get; set; }
}