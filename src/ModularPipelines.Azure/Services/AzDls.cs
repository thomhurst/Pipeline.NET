using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
public class AzDls
{
    public AzDls(
        AzDlsAccount account,
        AzDlsFs fs
    )
    {
        Account = account;
        Fs = fs;
    }

    public AzDlsAccount Account { get; }

    public AzDlsFs Fs { get; }
}