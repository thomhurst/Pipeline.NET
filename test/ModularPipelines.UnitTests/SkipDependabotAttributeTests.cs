﻿using Microsoft.Extensions.DependencyInjection;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Enums;
using ModularPipelines.Modules;
using Moq;

namespace ModularPipelines.UnitTests;

public class SkipDependabotAttributeTests : TestBase
{
    private class CanRunAttribute : RunConditionAttribute
    {
        public override Task<bool> Condition(IPipelineContext pipelineContext)
        {
            return Task.FromResult(true);
        }
    }

    private class CannotRunAttribute : RunConditionAttribute
    {
        public override Task<bool> Condition(IPipelineContext pipelineContext)
        {
            return Task.FromResult(false);
        }
    }
    
    [SkipIfDependabot]
    private class Module1 : Module
    {
        protected override Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return NothingAsync();
        }
    }
    
    [SkipIfDependabot, CanRun]
    private class Module2 : Module
    {
        protected override Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return NothingAsync();
        }
    }
    
    [SkipIfDependabot, CannotRun]
    private class Module3 : Module
    {
        protected override Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return NothingAsync();
        }
    }
    
    [SkipIfDependabot, CanRun, CannotRun]
    private class Module4 : Module
    {
        protected override Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return NothingAsync();
        }
    }

    [Test]
    public async Task Will_Not_Skip_If_Not_Dependabot()
    {
        var environmentVariables = new Mock<IEnvironmentVariables>();

        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .ConfigureServices((context, collection) => collection.AddSingleton(environmentVariables.Object))
            .AddModule<Module1>()
            .ExecutePipelineAsync();
        
        Assert.That(pipelineSummary.Modules.First().Status, Is.EqualTo(Status.Successful));
    }
    
    [Test]
    public async Task Will_Skip_If_Dependabot()
    {
        var environmentVariables = new Mock<IEnvironmentVariables>();
        
        environmentVariables.Setup(x => x.GetEnvironmentVariable("GITHUB_ACTOR", It.IsAny<EnvironmentVariableTarget>()))
            .Returns("dependabot[bot]");
        
        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .ConfigureServices((context, collection) => collection.AddSingleton(environmentVariables.Object))
            .AddModule<Module1>()
            .ExecutePipelineAsync();
        
        Assert.That(pipelineSummary.Modules.First().Status, Is.EqualTo(Status.Skipped));
    }
    
    [Test]
    public async Task Will_Run_When_Combination_Of_Mandatory_And_Runnable_Run_Category()
    {
        var environmentVariables = new Mock<IEnvironmentVariables>();
        
        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .ConfigureServices((context, collection) => collection.AddSingleton(environmentVariables.Object))
            .AddModule<Module2>()
            .ExecutePipelineAsync();
        
        Assert.That(pipelineSummary.Modules.First().Status, Is.EqualTo(Status.Successful));
    }
    
        
    [Test]
    public async Task Will__Not_Run_When_Combination_Of_Mandatory_And_Non_Runnable_Run_Category()
    {
        var environmentVariables = new Mock<IEnvironmentVariables>();
        
        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .ConfigureServices((context, collection) => collection.AddSingleton(environmentVariables.Object))
            .AddModule<Module3>()
            .ExecutePipelineAsync();
        
        Assert.That(pipelineSummary.Modules.First().Status, Is.EqualTo(Status.Skipped));
    }
    
        
    [Test]
    public async Task Will_Run_When_Combination_Of_Mandatory_And_Runnable_Run_Category2()
    {
        var environmentVariables = new Mock<IEnvironmentVariables>();
        
        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .ConfigureServices((context, collection) => collection.AddSingleton(environmentVariables.Object))
            .AddModule<Module4>()
            .ExecutePipelineAsync();
        
        Assert.That(pipelineSummary.Modules.First().Status, Is.EqualTo(Status.Successful));
    }
}