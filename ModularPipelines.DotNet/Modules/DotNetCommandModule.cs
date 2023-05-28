using System.Collections.ObjectModel;
using CliWrap;
using CliWrap.Buffered;
using ModularPipelines.Context;
using ModularPipelines.DotNet.Options;
using ModularPipelines.Models;
using ModularPipelines.Modules;

namespace ModularPipelines.DotNet.Modules;

public abstract class DotNetCommandModule : Module<BufferedCommandResult>
{
    public DotNetCommandModule(IModuleContext context) : base(context)
    {
    }

    protected abstract DotNetCommandModuleOptions Options { get; set; }

    protected override async Task<ModuleResult<BufferedCommandResult>?> ExecuteAsync(CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(Options.Command);
        
        var command = Cli.Wrap("dotnet");
        
        if (!string.IsNullOrEmpty(Options.WorkingDirectory))
        {
            command = command.WithWorkingDirectory(Options.WorkingDirectory);
        }

        var arguments = Options.Command.ToList();

        if (!string.IsNullOrEmpty(Options.TargetPath))
        {
            arguments.Add(Options.TargetPath);
        }

        if (Options.Configuration != null)
        {
            arguments.Add("-c");
            arguments.Add(Options.Configuration.ToString()!);
        }

        arguments.AddRange(Options.ExtraArguments ?? Array.Empty<string>());

        command = command.WithArguments(arguments);

        if (Options.EnvironmentVariables != null)
        {
            command = command.WithEnvironmentVariables(new ReadOnlyDictionary<string, string?>(Options.EnvironmentVariables));
        }

        var result = await command.ExecuteBufferedAsync(cancellationToken: cancellationToken);

        return result;
    }
}