using System.Runtime.CompilerServices;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Exceptions;
using ModularPipelines.Modules;
using ModularPipelines.TestHelpers;
using TUnit.Assertions;
using TUnit.Core;
using Status = ModularPipelines.Enums.Status;

namespace ModularPipelines.UnitTests;

public class DependsOnTests : TestBase
{
    private class Module1 : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return await NothingAsync();
        }
    }

    [DependsOn<Module1>]
    private class Module2 : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return await NothingAsync();
        }
    }

    [DependsOn<Module1>(IgnoreIfNotRegistered = true)]
    private class Module3 : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return await NothingAsync();
        }
    }

    [DependsOn<Module1>(IgnoreIfNotRegistered = true)]
    private class Module3WithGetIfRegistered : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            _ = GetModuleIfRegistered<Module1>();
            return await NothingAsync();
        }
    }

    [DependsOn<Module1>(IgnoreIfNotRegistered = true)]
    private class Module3WithGet : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            _ = GetModule<Module1>();
            return await NothingAsync();
        }
    }
    
    [DependsOn<DependsOnSelfModule>]
    private class DependsOnSelfModule : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            _ = GetModule<Module1>();
            return await NothingAsync();
        }
    }
    
    [DependsOn(typeof(ModuleFailedException))]
    private class DependsOnNonModule : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            _ = GetModule<Module1>();
            return await NothingAsync();
        }
    }

    [Test]
    public async Task No_Exception_Thrown_When_Dependent_Module_Present()
    {
        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .AddModule<Module1>()
            .AddModule<Module2>()
            .ExecutePipelineAsync();

        Assert.That(pipelineSummary.Status).Is.EqualTo(Status.Successful);
    }

    [Test]
    public async Task No_Exception_Thrown_When_Dependent_Module_Present2()
    {
        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .AddModule<Module1>()
            .AddModule<Module3>()
            .ExecutePipelineAsync();

        Assert.That(pipelineSummary.Status).Is.EqualTo(Status.Successful);
    }

    [Test]
    public void Exception_Thrown_When_Dependent_Module_Missing_And_No_Ignore_On_Attribute()
    {
        Assert.That(async () => await TestPipelineHostBuilder.Create()
                .AddModule<Module2>()
                .ExecutePipelineAsync()).
            Throws.Exception);
    }

    [Test]
    public async Task No_Exception_Thrown_When_Dependent_Module_Missing_And_Ignore_On_Attribute()
    {
        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .AddModule<Module3>()
            .ExecutePipelineAsync();

        Assert.That(pipelineSummary.Status).Is.EqualTo(Status.Successful);
    }

    [Test]
    public async Task No_Exception_Thrown_When_Dependent_Module_Missing_And_Get_If_Registered_Called()
    {
        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .AddModule<Module3WithGetIfRegistered>()
            .ExecutePipelineAsync();

        Assert.That(pipelineSummary.Status).Is.EqualTo(Status.Successful);
    }

    [Test]
    public void Exception_Thrown_When_Dependent_Module_Missing_And_Get_Module_Called()
    {
        Assert.That(async () => await TestPipelineHostBuilder.Create()
                .AddModule<Module3WithGet>()
                .ExecutePipelineAsync()).
            Throws.Exception);
    }
    
    [Test]
    public void Depends_On_Self_Module_Throws_Exception()
    {
        Assert.That(async () => await TestPipelineHostBuilder.Create()
                .AddModule<DependsOnSelfModule>()
                .ExecutePipelineAsync()).
            Throws.Exception.TypeOf<ModuleReferencingSelfException>();
    }
    
    [Test]
    public void Depends_On_Non_Module_Throws_Exception()
    {
        Assert.That(async () => await TestPipelineHostBuilder.Create()
                .AddModule<DependsOnNonModule>()
                .ExecutePipelineAsync()).
            Throws.Exception.Message.EqualTo("ModularPipelines.Exceptions.ModuleFailedException is not a Module class");
    }
}