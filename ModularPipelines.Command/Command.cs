﻿using System.Collections.ObjectModel;
using CliWrap;
using CliWrap.Buffered;
using Microsoft.Extensions.Logging;
using ModularPipelines.Command.Exceptions;
using ModularPipelines.Command.Options;
using ModularPipelines.Context;

namespace ModularPipelines.Command;

public class Command<T> : ICommand<T>
{
    private readonly IModuleContext<T> _context;

    public Command(IModuleContext<T> context)
    {
        _context = context;
    }
    
    public async Task<BufferedCommandResult> UsingCommandLineTool(CommandLineToolOptions options, CancellationToken cancellationToken = default)
    {
        var parsedArgs = string.Equals(options.Arguments?.ElementAtOrDefault(0), options.Tool) 
            ? options.Arguments?.Skip(1) : options.Arguments;
        
        var command = Cli.Wrap(options.Tool)
            .WithArguments(parsedArgs ?? Array.Empty<string>());
      
        if (options.WorkingDirectory != null)
        {
            command = command.WithWorkingDirectory(options.WorkingDirectory);
        }
        
        if (options.EnvironmentVariables != null)
        {
            command = command.WithEnvironmentVariables(new ReadOnlyDictionary<string, string?>(options.EnvironmentVariables));
        }

        if (options.LogInput)
        {
            _context.Logger.LogInformation("Executing Command: {Input}", command.ToString());
        }

        var result = await Of(command, cancellationToken);

        if (options.LogOutput)
        {
            _context.Logger.LogInformation("Command Result: {Output}",
                string.IsNullOrEmpty(result.StandardError)
                    ? result.StandardOutput
                    : result.StandardError);
        }

        return result;
    }

    public async Task<BufferedCommandResult> Of(CliWrap.Command command, CancellationToken cancellationToken = default)
    {
        var result = await command
            .WithValidation(CommandResultValidation.None)
            .ExecuteBufferedAsync(cancellationToken);

        if (result.ExitCode != 0)
        {
            var input = command.ToString();
            throw new CommandException(input, result);
        }

        return result;
    }
    
    
}