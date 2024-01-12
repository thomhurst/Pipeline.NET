using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Google.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("iam", "policies", "update")]
public record GcloudIamPoliciesUpdateOptions(
[property: PositionalArgument] string PolicyId,
[property: CommandSwitch("--attachment-point")] string AttachmentPoint,
[property: CommandSwitch("--kind")] string Kind,
[property: CommandSwitch("--policy-file")] string PolicyFile
) : GcloudOptions;