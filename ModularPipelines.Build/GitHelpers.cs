﻿using ModularPipelines.Context;
using ModularPipelines.Git.Extensions;
using ModularPipelines.Git.Options;

namespace ModularPipelines.Build;

public class GitHelpers
{
    public static async Task SetUserCommitInformation(IModuleContext context, CancellationToken cancellationToken)
    {
        await SetName(context, cancellationToken);
        await SetEmail(context, cancellationToken);
    }

    public static async Task SetName(IModuleContext context, CancellationToken cancellationToken)
    {
        await context.Git().Commands.Config(new GitConfigOptions
        {
            Local = true,
            Arguments = new List<string>
            {
                "user.name", "Tom Longhurst"
            }
        }, cancellationToken);
    }

    public static async Task SetEmail(IModuleContext context, CancellationToken cancellationToken)
    {
        await context.Git().Commands.Config(new GitConfigOptions
        {
            Local = true,
            Arguments = new List<string>
            {
                "user.email", "thomhurst@users.noreply.github.com"
            }
        }, cancellationToken);
    }

    public static async Task CheckoutBranch(IModuleContext context, string branchName, CancellationToken cancellationToken)
    {
        await context.Git().Commands.Remote(new GitRemoteOptions
        {
            Arguments = new[]
            {
                "set-url", "origin",
                $"https://x-access-token:{context.Environment.EnvironmentVariables.GetEnvironmentVariable("GITHUB_TOKEN")}@github.com/thomhurst/ModularPipelines"
            }
        }, cancellationToken);

        await context.Git().Commands.Fetch(new GitFetchOptions(), token: cancellationToken);

        await context.Git().Commands
            .Checkout(new GitCheckoutOptions(branchName), cancellationToken);
    }

    public static async Task CommitAndPush(IModuleContext context, string branchToPushTo, string message,
        CancellationToken cancellationToken)
    {
        await context.Git().Commands.Add(new GitAddOptions
        {
            All = true
        }, token: cancellationToken);

        await context.Git().Commands.Commit(new GitCommitOptions
        {
            Message = message
        }, token: cancellationToken);

        await context.Git().Commands.Push(new GitPushOptions
        {
            Arguments = new[] { "-u", "origin", $"HEAD:{branchToPushTo}" }
        }, token: cancellationToken);
    }
}