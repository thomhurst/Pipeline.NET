using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("spring-cloud")]
public class AzSpringCloudBuildService
{
    public AzSpringCloudBuildService(
        AzSpringCloudBuildServiceBuilder builder
    )
    {
        Builder = builder;
    }

    public AzSpringCloudBuildServiceBuilder Builder { get; }
}