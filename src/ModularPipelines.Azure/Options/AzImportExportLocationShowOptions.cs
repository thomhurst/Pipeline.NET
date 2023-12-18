using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("import-export", "location", "show")]
public record AzImportExportLocationShowOptions(
[property: CommandSwitch("--location")] string Location
) : AzOptions;