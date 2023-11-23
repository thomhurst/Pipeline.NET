using ModularPipelines.Context;
using ModularPipelines.Enums;
using ModularPipelines.Exceptions;
using ModularPipelines.Models;
using ModularPipelines.Modules;
using ModularPipelines.Requirements;

namespace ModularPipelines.UnitTests;

public class PipelineRequirementTests
{
    [Test]
    public async Task When_Requirement_Succeeds_Then_No_Error()
    {
        var pipelineSummary = await TestPipelineHostBuilder.Create()
            .AddModule<DummyModule>()
            .AddRequirement<SuccessfulRequirement>()
            .ExecutePipelineAsync();

        var dummyModule = pipelineSummary.Modules.OfType<DummyModule>().First();

        Assert.That(dummyModule.Status, Is.EqualTo(Status.Successful));
    }

    [Test]
    public void When_Requirement_Fails_Then_Error()
    {
        var executePipelineDelegate = () => TestPipelineHostBuilder.Create()
            .AddModule<DummyModule>()
            .AddRequirement<FailingRequirement>()
            .ExecutePipelineAsync();

        Assert.That(executePipelineDelegate, Throws.Exception.TypeOf<FailedRequirementsException>()
            .With.Message.EqualTo("Requirements failed:\r\nFailingRequirement"));
    }

    private class DummyModule : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
        {
            await Task.Yield();
            return new Dictionary<string, object>();
        }
    }

    private class SuccessfulRequirement : IPipelineRequirement
    {
        public async Task<RequirementDecision> MustAsync(IPipelineHookContext context)
        {
            await Task.Yield();
            return true;
        }
    }

    private class FailingRequirement : IPipelineRequirement
    {
        public async Task<RequirementDecision> MustAsync(IPipelineHookContext context)
        {
            await Task.Yield();
            return false;
        }
    }
}
