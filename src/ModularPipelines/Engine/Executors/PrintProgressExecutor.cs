﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using ModularPipelines.Helpers;
using ModularPipelines.Models;

namespace ModularPipelines.Engine.Executors;

internal class PrintProgressExecutor : IPrintProgressExecutor
{
    private readonly EngineCancellationToken _engineCancellationToken;
    private readonly IConsolePrinter _consolePrinter;

    public PrintProgressExecutor(EngineCancellationToken engineCancellationToken,
        IConsolePrinter consolePrinter)
    {
        _engineCancellationToken = engineCancellationToken;
        _consolePrinter = consolePrinter;
    }
    
    [StackTraceHidden, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public async Task ExecuteWithProgress(OrganizedModules organizedModules, Func<Task> executeDelegate)
    {
        var printProgressCancellationTokenSource =
            CancellationTokenSource.CreateLinkedTokenSource(_engineCancellationToken.Token);

        var printProgressTask =
            _consolePrinter.PrintProgress(organizedModules, printProgressCancellationTokenSource.Token);
        
        try
        {
            await executeDelegate();
        }
        finally
        {
            printProgressCancellationTokenSource.CancelAfter(5000);

            await printProgressTask;
        }
    }
}