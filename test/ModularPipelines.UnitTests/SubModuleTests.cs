﻿using Microsoft.Extensions.Logging;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Modules;
using EnumerableAsyncProcessor.Extensions;
using ModularPipelines.Exceptions;

namespace ModularPipelines.UnitTests;

public class SubModuleTests : TestBase
{
    private class SubModulesWithReturnTypeModule : Module<string[]>
    {
        protected override async Task<string[]?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return await new[] { "1", "2", "3" }.ToAsyncProcessorBuilder()
                .SelectAsync(name => SubModule(name, () =>
                {
                    context.Logger.LogInformation("Running Submodule {Submodule}", name);
                    return Task.FromResult(name);
                }))
                .ProcessInParallel();
        }
    }

    private class SubModulesWithoutReturnTypeModule : Module<string[]>
    {
        protected override async Task<string[]?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            await new[] { "1", "2", "3" }.ToAsyncProcessorBuilder()
                .ForEachAsync(name => SubModule(name, async () =>
                {
                    context.Logger.LogInformation("Running Submodule {Submodule}", name);
                    await Task.Yield();
                }))
                .ProcessInParallel();

            return await NothingAsync();
        }
    }
    
    private class FailingSubModulesWithReturnTypeModule : Module<string[]>
    {
        protected override async Task<string[]?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return await new[] { "1", "2", "3" }.ToAsyncProcessorBuilder()
                .SelectAsync(name => SubModule<string>(name, async () =>
                {
                    await Task.Yield();
                    throw new Exception();
                }))
                .ProcessInParallel();
        }
    }

    private class FailingSubModulesWithoutReturnTypeModule : Module<string[]>
    {
        protected override async Task<string[]?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            await new[] { "1", "2", "3" }.ToAsyncProcessorBuilder()
                .ForEachAsync(name => SubModule(name, async () =>
                {
                    await Task.Yield();
                    throw new Exception();
                }))
                .ProcessInParallel();

            return await NothingAsync();
        }
    }
    
    private class FailingSubModulesWithReturnTypeModuleSynchronous : Module<string[]>
    {
        protected override async Task<string[]?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            return await new[] { "1", "2", "3" }
                .ToAsyncProcessorBuilder()
                .SelectAsync(async name => await SubModule<string>(name, () =>
                {
                    if(1.ToString() == "1")
                    {
                        throw new Exception();
                    }

                    return "";
                }))
                .ProcessInParallel();
        }
    }

    private class FailingSubModulesWithoutReturnTypeModuleSynchronous : Module<string[]>
    {
        protected override async Task<string[]?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            await new[] { "1", "2", "3" }.ToAsyncProcessorBuilder()
                .ForEachAsync(name => SubModule(name, () =>
                {
                    if(1.ToString() == "1")
                    {
                        throw new Exception();
                    }
                }))
                .ProcessInParallel();

            return await NothingAsync();
        }
    }

    [Test]
    public async Task Submodule_With_Return_Type_Does_Not_Fail()
    {
        var module = await RunModule<SubModulesWithReturnTypeModule>();

        var results = await module;

        Assert.Multiple(() =>
        {
            Assert.That(results.ModuleResultType, Is.EqualTo(ModuleResultType.Success));
            Assert.That(results.Value, Is.EquivalentTo(new List<string> { "1", "2", "3" }));
        });
    }
    
    [Test]
    public async Task Submodule_Without_Return_Type_Does_Not_Fail()
    {
        var module = await RunModule<SubModulesWithoutReturnTypeModule>();

        var results = await module;

        Assert.Multiple(() =>
        {
            Assert.That(results.ModuleResultType, Is.EqualTo(ModuleResultType.Success));
            Assert.That(results.Value, Is.Null);
        });
    }
    
    [Test]
    public void Failing_Submodule_With_Return_Type_Fails()
    {
        var moduleFailedException = Assert.ThrowsAsync<ModuleFailedException>(RunModule<FailingSubModulesWithReturnTypeModule>);

        Assert.Multiple(() =>
        {
            Assert.That(moduleFailedException?.InnerException, Is.TypeOf<SubModuleFailedException>());
            Assert.That((SubModuleFailedException) moduleFailedException!.InnerException!, Has.Message.EqualTo("The Sub-Module 1 has failed."));
        });
    }
    
    [Test]
    public void Failing_Submodule_Without_Return_Type_Fails()
    {
        var moduleFailedException = Assert.ThrowsAsync<ModuleFailedException>(RunModule<FailingSubModulesWithoutReturnTypeModule>);

        Assert.Multiple(() =>
        {
            Assert.That(moduleFailedException?.InnerException, Is.TypeOf<SubModuleFailedException>());
            Assert.That((SubModuleFailedException) moduleFailedException!.InnerException!, Has.Message.EqualTo("The Sub-Module 1 has failed."));
        });
    }
    
    [Test]
    public void Failing_Submodule_With_Return_Type_Fails_Synchronous()
    {
        var moduleFailedException = Assert.ThrowsAsync<ModuleFailedException>(RunModule<FailingSubModulesWithReturnTypeModuleSynchronous>);

        Assert.Multiple(() =>
        {
            Assert.That(moduleFailedException?.InnerException, Is.TypeOf<SubModuleFailedException>());
            Assert.That((SubModuleFailedException) moduleFailedException!.InnerException!, Has.Message.EqualTo("The Sub-Module 1 has failed."));
        });
    }
    
    [Test]
    public void Failing_Submodule_Without_Return_Type_Fails_Synchronous()
    {
        var moduleFailedException = Assert.ThrowsAsync<ModuleFailedException>(RunModule<FailingSubModulesWithoutReturnTypeModuleSynchronous>);

        Assert.Multiple(() =>
        {
            Assert.That(moduleFailedException?.InnerException, Is.TypeOf<SubModuleFailedException>());
            Assert.That((SubModuleFailedException) moduleFailedException!.InnerException!, Has.Message.EqualTo("The Sub-Module 1 has failed."));
        });
    }
}