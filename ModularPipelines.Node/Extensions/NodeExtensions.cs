﻿using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ModularPipelines.Context;
using ModularPipelines.Engine;

namespace ModularPipelines.Node.Extensions;

public static class NodeExtensions
{
#pragma warning disable CA2255
    [ModuleInitializer]
#pragma warning restore CA2255
    public static void RegisterNodeContext()
    {
        ServiceContextRegistry.RegisterContext(collection => RegisterNodeContext(collection));
    }
    
    public static IServiceCollection RegisterNodeContext(this IServiceCollection services)
    {
        services.TryAddSingleton<INode, Node>();
        services.TryAddSingleton<INvm, Nvm>();
        services.TryAddSingleton<INpm, Npm>();
        return services;
    }

    public static INode Node(this IModuleContext context) => context.ServiceProvider.GetRequiredService<INode>();
}