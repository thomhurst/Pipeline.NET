using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ModularPipelines.Engine;
using ModularPipelines.Enums;
using ModularPipelines.Helpers;
using ModularPipelines.Options;

namespace ModularPipelines.Logging;

internal class CommandLogger : ICommandLogger
{
    private readonly IModuleLoggerProvider _moduleLoggerProvider;
    private readonly IOptions<PipelineOptions> _pipelineOptions;
    private readonly ISecretObfuscator _secretObfuscator;
    private readonly object _lock = new();

    public CommandLogger(IModuleLoggerProvider moduleLoggerProvider,
        IOptions<PipelineOptions> pipelineOptions,
        ISecretObfuscator secretObfuscator)
    {
        _moduleLoggerProvider = moduleLoggerProvider;
        _pipelineOptions = pipelineOptions;
        _secretObfuscator = secretObfuscator;
    }

    private ILogger Logger => _moduleLoggerProvider.GetLogger();

    public void Log(CommandLineToolOptions options, string? inputToLog, int? exitCode, TimeSpan? runTime, string standardOutput, string standardError)
    {
        if (options.CommandLogging == CommandLogging.None)
        {
            return;
        }

        var optionsCommandLogging = options.CommandLogging ?? _pipelineOptions.Value.DefaultCommandLogging;

        lock (_lock)
        {
            if (options.InternalDryRun && ShouldLogInput(optionsCommandLogging))
            {
                Logger.LogInformation("---Executing Command---\r\n\t{Input}", inputToLog);
                Logger.LogInformation("---Dry-Run Command - No Output---");
                return;
            }

            if (ShouldLogInput(optionsCommandLogging))
            {
                var inputLoggingManipulator = options.InputLoggingManipulator ?? (s => s);

                Logger.LogInformation("""
                                      ---Executing Command---
                                      {Input}
                                      """,
                    inputLoggingManipulator(_secretObfuscator.Obfuscate(inputToLog, options)));
            }
            else
            {
                Logger.LogInformation("""
                                      ---Executing Command---
                                      ********
                                      """);
            }

            if (optionsCommandLogging.HasFlag(CommandLogging.ExitCode))
            {
                Logger.LogInformation("""
                                      ---Exit Code----
                                      {ExitCode}
                                      """, exitCode);
            }

            if (optionsCommandLogging.HasFlag(CommandLogging.Duration))
            {
                Logger.LogInformation("""
                                      ---Duration---
                                      {Duration}
                                      """, runTime?.ToDisplayString());
            }

            if (ShouldLogOutput(optionsCommandLogging))
            {
                var outputLoggingManipulator = options.OutputLoggingManipulator ?? (s => s);

                Logger.LogInformation("""
                                      ---Command Result---
                                      {Output}
                                      """, outputLoggingManipulator(_secretObfuscator.Obfuscate(standardOutput, options)));
            }

            if (ShouldLogError(optionsCommandLogging, exitCode))
            {
                var outputLoggingManipulator = options.OutputLoggingManipulator ?? (s => s);

                Logger.LogInformation("""
                                      ---Command Error---
                                      {Error}
                                      """, outputLoggingManipulator(_secretObfuscator.Obfuscate(standardError, options)));
            }
        }
    }

    private static bool ShouldLogInput(CommandLogging commandLogging)
    {
        return commandLogging.HasFlag(CommandLogging.Input);
    }

    private static bool ShouldLogOutput(CommandLogging commandLogging)
    {
        return commandLogging.HasFlag(CommandLogging.Output);
    }

    private static bool ShouldLogError(CommandLogging commandLogging, int? resultCode)
    {
        return resultCode != 0 && commandLogging.HasFlag(CommandLogging.Error);
    }
}