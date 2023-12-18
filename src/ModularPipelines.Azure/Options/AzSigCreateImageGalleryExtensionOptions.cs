using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("sig", "create", "(image-gallery", "extension)")]
public record AzSigCreateImageGalleryExtensionOptions(
[property: CommandSwitch("--gallery-name")] string GalleryName,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions
{
    [CommandSwitch("--description")]
    public string? Description { get; set; }

    [CommandSwitch("--eula")]
    public string? Eula { get; set; }

    [CommandSwitch("--location")]
    public string? Location { get; set; }

    [CommandSwitch("--permissions")]
    public string? Permissions { get; set; }

    [CommandSwitch("--public-name-prefix")]
    public string? PublicNamePrefix { get; set; }

    [CommandSwitch("--publisher-email")]
    public string? PublisherEmail { get; set; }

    [CommandSwitch("--publisher-uri")]
    public string? PublisherUri { get; set; }

    [BooleanCommandSwitch("--soft-delete")]
    public bool? SoftDelete { get; set; }

    [CommandSwitch("--tags")]
    public string? Tags { get; set; }
}

