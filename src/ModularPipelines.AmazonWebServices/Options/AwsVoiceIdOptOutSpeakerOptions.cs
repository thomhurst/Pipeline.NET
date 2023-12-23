using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.AmazonWebServices.Options;

[ExcludeFromCodeCoverage]
[CommandPrecedingArguments("voice-id", "opt-out-speaker")]
public record AwsVoiceIdOptOutSpeakerOptions(
[property: CommandSwitch("--domain-id")] string DomainId,
[property: CommandSwitch("--speaker-id")] string SpeakerId
) : AwsOptions
{
    [CommandSwitch("--generate-cli-skeleton")]
    public string? GenerateCliSkeleton { get; set; }
}