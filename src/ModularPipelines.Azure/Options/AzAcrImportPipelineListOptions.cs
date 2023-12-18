using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Azure.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("acr", "import-pipeline", "list")]
public record AzAcrImportPipelineListOptions(
[property: CommandSwitch("--registry")] string Registry,
[property: CommandSwitch("--resource-group")] string ResourceGroup
) : AzOptions;