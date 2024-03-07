﻿using Microsoft.Extensions.Logging;
using ModularPipelines.Context;
using ModularPipelines.Git.Attributes;
using ModularPipelines.Git.Extensions;
using ModularPipelines.Git.Options;
using ModularPipelines.GitHub.Attributes;
using ModularPipelines.GitHub.Extensions;
using ModularPipelines.Modules;

namespace ModularPipelines.Build.Modules;

[SkipIfNoGitHubToken]
public class DependabotCommitsModule : Module<string>
{
    protected override async Task<string?> ExecuteAsync(IPipelineContext context, CancellationToken cancellationToken)
    {
        var repositoryInfo = context.GitHub().RepositoryInfo;
        
        var latestRelease = await context.GitHub().Client.Repository.Release.GetLatest(repositoryInfo.Owner, repositoryInfo.RepositoryName);
        
        var sha = latestRelease.TargetCommitish;

        var commitsResult = await context.Git().Commands.Log(new GitLogOptions
        {
            Author = "dependabot",
            Format = "%s",
            Arguments = [$"{sha}..HEAD"],
        }, cancellationToken);

        var commits = commitsResult.StandardOutput;
        
        context.Logger.LogInformation("Commits: {Commits}", commits);

        return commits;
    }
}