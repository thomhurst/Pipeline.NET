using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Azure.Options;
using ModularPipelines.Context;
using ModularPipelines.Models;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
public class AzOrbital
{
    public AzOrbital(
        AzOrbitalAvailableGroundStation availableGroundStation,
        AzOrbitalContactProfile contactProfile,
        AzOrbitalOperationResult operationResult,
        AzOrbitalSpacecraft spacecraft
    )
    {
        AvailableGroundStation = availableGroundStation;
        ContactProfile = contactProfile;
        OperationResult = operationResult;
        Spacecraft = spacecraft;
    }

    public AzOrbitalAvailableGroundStation AvailableGroundStation { get; }

    public AzOrbitalContactProfile ContactProfile { get; }

    public AzOrbitalOperationResult OperationResult { get; }

    public AzOrbitalSpacecraft Spacecraft { get; }
}