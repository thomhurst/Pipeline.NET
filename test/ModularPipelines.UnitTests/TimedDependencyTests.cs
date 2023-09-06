using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Modules;

namespace ModularPipelines.UnitTests;

public class TimedDependencyTests
{
    [Test]
    public async Task OneSecondModule_WillWaitForFiveSecondModule_ThenExecute()
    {
        var modules = await TestPipelineHostBuilder.Create()
            .AddModule<FiveSecondModule>()
            .AddModule<OneSecondModuleDependentOnFiveSecondModule>()
            .ExecutePipelineAsync();

        var fiveSecondModule = modules.OfType<FiveSecondModule>().Single();
        var oneSecondModuleDependentOnFiveSecondModule = modules.OfType<OneSecondModuleDependentOnFiveSecondModule>().Single();

        Assert.Multiple(() =>
        {
            // 5 + 1
            Assert.That(oneSecondModuleDependentOnFiveSecondModule.Duration, Is.GreaterThanOrEqualTo(TimeSpan.FromMilliseconds(900)));
            Assert.That(oneSecondModuleDependentOnFiveSecondModule.EndTime, Is.GreaterThanOrEqualTo(fiveSecondModule.StartTime + TimeSpan.FromMilliseconds(5900)));
            Assert.That(oneSecondModuleDependentOnFiveSecondModule.StartTime, Is.GreaterThanOrEqualTo(fiveSecondModule.EndTime));
        });
    }

    private class FiveSecondModule : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IModuleContext context, CancellationToken cancellationToken)
        {
            await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
            return new Dictionary<string, object>();
        }
    }

    [DependsOn<FiveSecondModule>]
    private class OneSecondModuleDependentOnFiveSecondModule : Module
    {
        protected override async Task<IDictionary<string, object>?> ExecuteAsync(IModuleContext context, CancellationToken cancellationToken)
        {
            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            return new Dictionary<string, object>();
        }
    }
}
