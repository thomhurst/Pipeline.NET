﻿using Microsoft.Extensions.Options;
using ModularPipelines.Attributes;
using ModularPipelines.Build.Settings;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Modules;
using ModularPipelines.Options;

namespace ModularPipelines.Build.Modules;

[DependsOn<RunUnitTestsModule>]
public class CodacyCodeCoverageUploader : Module<CommandResult>
{
    private readonly IOptions<CodacySettings> _options;

    public CodacyCodeCoverageUploader(IOptions<CodacySettings> options)
    {
        _options = options;
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
            Arguments = new []{ "report", "-r", coverageOutputFile.Path, "--commit-uuid", context.Git().Information.LastCommitSha! },
            EnvironmentVariables = new Dictionary<string, string?>
            {
                ["CODACY_PROJECT_TOKEN"] = _options.Value.ApiKey
            }
        }, cancellationToken);
    }
}