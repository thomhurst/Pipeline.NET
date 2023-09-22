﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ModularPipelines.Attributes;
using ModularPipelines.Build.Settings;
using ModularPipelines.Context;
using ModularPipelines.Git.Extensions;
using ModularPipelines.Modules;
using Newtonsoft.Json;
using Octokit;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ModularPipelines.Build.Modules;

[RunOnLinux]
public class WaitForOtherOperatingSystemBuilds : Module<List<WorkflowRun>>
{
    private readonly IOptions<GitHubSettings> _gitHubSettings;
    private readonly GitHubClient _gitHubClient;

    protected override Task<bool> ShouldSkip(IPipelineContext context)
    {
        return Task.FromResult(_gitHubSettings.Value.Ref is null);
    }

    public WaitForOtherOperatingSystemBuilds(IOptions<GitHubSettings> gitHubSettings, GitHubClient gitHubClient)
    {
        _gitHubSettings = gitHubSettings;
        _gitHubClient = gitHubClient;
    }
    
    protected override async Task<List<WorkflowRun>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
    {
        var commitSha = context.Git().Information.LastCommitSha;
        
        // It'll take at least 1.5 minutes to finish - So wait before trying to fetch to give it time to start
        await Task.Delay(TimeSpan.FromMinutes(1.5), cancellationToken);

        var windowsRuns = await _gitHubClient.Actions.Workflows.Runs.ListByWorkflow(BuildConstants.Owner, BuildConstants.RepositoryName, "dotnet-windows.yml");
        var macRuns = await _gitHubClient.Actions.Workflows.Runs.ListByWorkflow(BuildConstants.Owner, BuildConstants.RepositoryName, "dotnet-mac.yml");

        context.Logger.LogInformation("Sha: {Sha}", commitSha);
        context.Logger.LogInformation("Windows: {Runs}", JsonConvert.SerializeObject(windowsRuns.WorkflowRuns.Select(x => x.HeadSha).ToList()));
        context.Logger.LogInformation("Mac: {Runs}", JsonConvert.SerializeObject(macRuns.WorkflowRuns.Select(x => x.HeadSha).ToList()));

        var windowsRun = windowsRuns.WorkflowRuns.First(x => x.HeadSha == commitSha);
        var macRun = macRuns.WorkflowRuns.First(x => x.HeadSha == commitSha);

        var results = await Task.WhenAll(WaitFor(windowsRun, cancellationToken), WaitFor(macRun, cancellationToken));

        return results.ToList();
    }

    private async Task<WorkflowRun> WaitFor(WorkflowRun workflowRun, CancellationToken cancellationToken)
    {
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            var run = await _gitHubClient.Actions.Workflows.Runs.Get(BuildConstants.Owner, BuildConstants.RepositoryName, workflowRun.Id);
            
            if (run?.Conclusion.HasValue is true)
            {
                return run;
            }

            await Task.Delay(TimeSpan.FromSeconds(15), cancellationToken);
        }
    }
}