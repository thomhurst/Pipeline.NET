﻿using Microsoft.Extensions.Options;
using ModularPipelines.Attributes;
using ModularPipelines.Build.Settings;
using ModularPipelines.Context;
using ModularPipelines.Extensions;
using ModularPipelines.Git.Extensions;
using ModularPipelines.Models;
using ModularPipelines.Modules;
using Octokit;

namespace ModularPipelines.Build.Modules;

[RunOnLinux]
[SkipIfDependabot]
public class WaitForOtherOperatingSystemBuilds : Module<List<WorkflowRun>>
{
    private readonly IOptions<GitHubSettings> _gitHubSettings;
    private readonly GitHubClient _gitHubClient;

    public WaitForOtherOperatingSystemBuilds(IOptions<GitHubSettings> gitHubSettings, GitHubClient gitHubClient)
    {
        _gitHubSettings = gitHubSettings;
        _gitHubClient = gitHubClient;
    }

    /// <inheritdoc/>
    protected override Task<SkipDecision> ShouldSkip(IPipelineContext context)
    {
        return context.Git().Information.BranchName != "main" && _gitHubSettings.Value?.PullRequest?.Sha is null
            ? SkipDecision.Skip("No github commit sha found").AsTask()
            : SkipDecision.DoNotSkip.AsTask();
    }

    /// <inheritdoc/>
    protected override async Task<List<WorkflowRun>?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
    {
        var commitSha = _gitHubSettings.Value.PullRequest?.Sha ?? context.Git().Information.LastCommitSha;

        // It'll take at least 1.5 minutes to finish - So wait before trying to fetch to give it time to start
        await Task.Delay(TimeSpan.FromMinutes(1.5), cancellationToken);

        var windowsRuns = await _gitHubClient.Actions.Workflows.Runs.ListByWorkflow(BuildConstants.Owner, BuildConstants.RepositoryName, "dotnet-windows.yml");
        var macRuns = await _gitHubClient.Actions.Workflows.Runs.ListByWorkflow(BuildConstants.Owner, BuildConstants.RepositoryName, "dotnet-mac.yml");

        var windowsRun = windowsRuns.WorkflowRuns.FirstOrDefault(x => x.HeadSha == commitSha);
        var macRun = macRuns.WorkflowRuns.FirstOrDefault(x => x.HeadSha == commitSha);

        var results = await Task.WhenAll(WaitFor(windowsRun, cancellationToken), WaitFor(macRun, cancellationToken));

        return results.OfType<WorkflowRun>().ToList();
    }

    private async Task<WorkflowRun?> WaitFor(WorkflowRun? workflowRun, CancellationToken cancellationToken)
    {
        if (workflowRun == null)
        {
            return null;
        }

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