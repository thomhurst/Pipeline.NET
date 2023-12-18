using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
public class AzDynatrace
{
    public AzDynatrace(
        AzDynatraceMonitor monitor
    )
    {
        Monitor = monitor;
    }

    public AzDynatraceMonitor Monitor { get; }
}