﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Pipeline.NET.Attributes;
using Pipeline.NET.Build.Settings;
using Pipeline.NET.Context;
using Pipeline.NET.NuGet;

namespace Pipeline.NET.Build.Modules;

[DependsOn<RunUnitTestsModule>]
[DependsOn<PackagePathsParserModule>]
public class UploadPackagesToNugetModule : NuGetUploadModule
{
    private readonly IOptions<NuGetSettings> _options;

    public UploadPackagesToNugetModule(IModuleContext context, IOptions<NuGetSettings> options) : base(context)
    {
        ArgumentNullException.ThrowIfNull(options.Value.ApiKey);
        
        _options = options;
    }

    protected override async Task InitialiseAsync()
    {
        PackagePaths = (await GetModule<PackagePathsParserModule>()).Value!;
        
        foreach (var packagePath in PackagePaths)
        {
            Context.Logger.LogInformation("Uploading {File}", packagePath);
        }
        
        await base.InitialiseAsync();
    }

    protected override IEnumerable<string> PackagePaths { get; set; }

    protected override string ApiKey
    {
        get
        {
            ArgumentNullException.ThrowIfNull(_options.Value.ApiKey);
            return _options.Value.ApiKey!;
        }
        set
        {
        }
    }

    protected override Uri FeedUri { get; set; } = new("https://api.nuget.org/v3/index.json");
}