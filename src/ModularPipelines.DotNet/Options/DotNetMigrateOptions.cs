using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.DotNet.Options;

[CommandPrecedingArguments("migrate", "[<SOLUTION_FILE|PROJECT_DIR>]")]
[ExcludeFromCodeCoverage]
public record DotNetMigrateOptions : DotNetOptions
{
    [PositionalArgument(PlaceholderName = "[<SOLUTION_FILE|PROJECT_DIR>]")]
    public string? SolutionFileProjectDir { get; set; }

    [CommandSwitch("--format-report-file-json")]
    public string? FormatReportFileJson { get; set; }

    [CommandSwitch("--report-file")]
    public string? ReportFile { get; set; }

    [BooleanCommandSwitch("--skip-project-references")]
    public bool? SkipProjectReferences { get; set; }

    [BooleanCommandSwitch("--skip-backup")]
    public bool? SkipBackup { get; set; }

    [CommandSwitch("--template-file")]
    public string? TemplateFile { get; set; }

    [BooleanCommandSwitch("--sdk-package-version")]
    public bool? SdkPackageVersion { get; set; }

    [BooleanCommandSwitch("--xproj-file")]
    public bool? XprojFile { get; set; }
}
