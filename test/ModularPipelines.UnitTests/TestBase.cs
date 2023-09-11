﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModularPipelines.Extensions;
using ModularPipelines.Modules;

namespace ModularPipelines.UnitTests;

[TestFixture, FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class TestBase
{
    public async Task<T> RunModule<T>() where T : ModuleBase
    {
        var host = await TestPipelineHostBuilder.Create()
            .AddModule<T>()
            .BuildHostAsync();
        
        var results = await host.ExecutePipelineAsync();

        host.Dispose();
        
        return results.OfType<T>().Single();
    }

    public async Task<T> GetService<T>() where T : notnull
    {
        var valueTuple = await GetService<T>(null);
        return valueTuple.T;
    }
    
    public async Task<(T T, IHost Host)> GetService<T>(Action<HostBuilderContext, IServiceCollection>? configureServices) where T : notnull
    {
        var host = await TestPipelineHostBuilder
            .Create()
            .ConfigureServices((context, collection) => configureServices?.Invoke(context, collection))
            .BuildHostAsync();
        
        var serviceProvider = host.Services;
        
        return (serviceProvider.GetRequiredService<T>(), host);
    }
}
