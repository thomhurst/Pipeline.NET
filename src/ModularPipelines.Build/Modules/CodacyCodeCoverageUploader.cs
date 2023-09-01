﻿using Microsoft.Extensions.Options;
using ModularPipelines.Attributes;
using ModularPipelines.Build.Settings;
using ModularPipelines.Context;
using ModularPipelines.Git.Extensions;
using ModularPipelines.Models;
using ModularPipelines.Modules;
using ModularPipelines.Options;

namespace ModularPipelines.Build.Modules;

[DependsOn<RunUnitTestsModule>]
public class CodacyCodeCoverageUploader : Module<CommandResult>
{
    private readonly IOptions<CodacySettings> _options;
    private readonly IOptions<GitHubSettings> _githubSettings;

    public CodacyCodeCoverageUploader(IOptions<CodacySettings> options,
    IOptions<GitHubSettings> githubSettings)
    {
        _options = options;
        _githubSettings = githubSettings;
    }

    protected override Task<bool> ShouldSkip(IModuleContext context)
    {
        if (!context.BuildSystemDetector.IsRunningOnGitHubActions)
        {
            return Task.FromResult(true);
        }

        if (_githubSettings.Value.Actor == "dependabot[bot]")
        {
            return Task.FromResult(true);
        }
        
        return Task.FromResult(string.IsNullOrEmpty(_githubSettings.Value.PullRequest?.Branch));
    }
    
    protected override async Task<ModuleResult<CommandResult>?> ExecuteAsync(IModuleContext context, CancellationToken cancellationToken)
    {
        var coverageOutputFile = context.Environment.GitRootDirectory!.GetFiles(x => x.Path.EndsWith("coverage.cobertura.xml")).First();
        
        var scriptFile =
            await context.Downloader.DownloadFileAsync(
                new DownloadFileOptions(new Uri("https://coverage.codacy.com/get.sh")), cancellationToken);

        await context.Bash.Command(new BashCommandOptions($"ls -l {scriptFile}"), cancellationToken);
        
        await context.Bash.Command(new BashCommandOptions($"chmod u+x {scriptFile}"), cancellationToken);

        return await context.Bash.FromFile(new BashFileOptions(scriptFile)
        {
            Arguments = new []{ "report", "-r", coverageOutputFile.Path },
            EnvironmentVariables = new Dictionary<string, string?>
            {
                ["CODACY_PROJECT_TOKEN"] = _options.Value.ApiKey
            }
        }, cancellationToken);
    }
}
