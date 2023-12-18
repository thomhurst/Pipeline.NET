using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("quantum", "target", "set")]
public record AzQuantumTargetSetOptions(
[property: CommandSwitch("--target-id")] string TargetId
) : AzOptions
{
}