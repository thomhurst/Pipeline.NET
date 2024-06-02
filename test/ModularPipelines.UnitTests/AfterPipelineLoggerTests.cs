﻿using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ModularPipelines.Context;
using ModularPipelines.Extensions;
using ModularPipelines.Modules;
using ModularPipelines.TestHelpers;
using NReco.Logging.File;
using TUnit.Assertions.Extensions;
using File = ModularPipelines.FileSystem.File;
using Type = System.Type;

namespace ModularPipelines.UnitTests;

public class AfterPipelineLoggerTests
{
    private class AfterPipelineLoggingModule : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            context.LogOnPipelineEnd("Blah!");
            await Task.CompletedTask;
            return null;
        }
    }
    
    private class AfterPipelineLoggingWithExceptionModule : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            context.LogOnPipelineEnd("Blah!");
            await Task.CompletedTask;
            throw new Exception();
        }
    }
    
    [Test]
    public async Task LogsAfterPipeline()
    {
        var stringBuilder = new StringBuilder();
        var host = await TestPipelineHostBuilder.Create()
            .ConfigureServices((_, collection) =>
            {
                collection.AddSingleton(stringBuilder);
                collection.AddSingleton(typeof(ILogger<>), typeof(StringLogger<>));
            })
            .AddModule<AfterPipelineLoggingModule>()
            .BuildHostAsync();

        await host.ExecutePipelineAsync();

        await host.DisposeAsync();
        
        await Assert.That(stringBuilder.ToString().Trim()).Does.EndWith("Blah!");
    }
    
    [Test]
    public async Task LogsAfterPipelineWithException()
    {
        var stringBuilder = new StringBuilder();
        var host = await TestPipelineHostBuilder.Create()
            .ConfigureServices((_, collection) =>
            {
                collection.AddSingleton(stringBuilder);
                collection.AddSingleton(typeof(ILogger<>), typeof(StringLogger<>));
            })
            .AddModule<AfterPipelineLoggingWithExceptionModule>()
            .BuildHostAsync();

        await host.ExecutePipelineAsync();

        await host.DisposeAsync();
        
        await Assert.That(stringBuilder.ToString().Trim()).Does.EndWith("Blah!");
    }
}