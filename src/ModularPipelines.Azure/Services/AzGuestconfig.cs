using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;
using ModularPipelines.Azure.Options;

namespace ModularPipelines.Azure.Services;

[ExcludeFromCodeCoverage]
public class AzGuestconfig
{
    public AzGuestconfig(
        AzGuestconfigGuestConfigurationAssignment guestConfigurationAssignment,
        AzGuestconfigGuestConfigurationAssignmentReport guestConfigurationAssignmentReport,
        AzGuestconfigGuestConfigurationHcrpAssignment guestConfigurationHcrpAssignment,
        AzGuestconfigGuestConfigurationHcrpAssignmentReport guestConfigurationHcrpAssignmentReport
    )
    {
        GuestConfigurationAssignment = guestConfigurationAssignment;
        GuestConfigurationAssignmentReport = guestConfigurationAssignmentReport;
        GuestConfigurationHcrpAssignment = guestConfigurationHcrpAssignment;
        GuestConfigurationHcrpAssignmentReport = guestConfigurationHcrpAssignmentReport;
    }

    public AzGuestconfigGuestConfigurationAssignment GuestConfigurationAssignment { get; }

    public AzGuestconfigGuestConfigurationAssignmentReport GuestConfigurationAssignmentReport { get; }

    public AzGuestconfigGuestConfigurationHcrpAssignment GuestConfigurationHcrpAssignment { get; }

    public AzGuestconfigGuestConfigurationHcrpAssignmentReport GuestConfigurationHcrpAssignmentReport { get; }
}