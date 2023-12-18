using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Options;

[ExcludeFromCodeCoverage]
public class AzRedis
{
    public AzRedis(
        AzRedisFirewallRules firewallRules,
        AzRedisIdentity identity,
        AzRedisPatchSchedule patchSchedule,
        AzRedisServerLink serverLink,
        ICommand internalCommand
    )
    {
        FirewallRules = firewallRules;
        Identity = identity;
        PatchSchedule = patchSchedule;
        ServerLink = serverLink;
        _command = internalCommand;
    }

    private readonly ICommand _command;

    public AzRedisFirewallRules FirewallRules { get; }

    public AzRedisIdentity Identity { get; }

    public AzRedisPatchSchedule PatchSchedule { get; }

    public AzRedisServerLink ServerLink { get; }

    public async Task<CommandResult> Create(AzRedisCreateOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Delete(AzRedisDeleteOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Export(AzRedisExportOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> ForceReboot(AzRedisForceRebootOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Import(AzRedisImportOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> ImportMethod(AzRedisImportMethodOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> List(AzRedisListOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> ListKeys(AzRedisListKeysOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> RegenerateKeys(AzRedisRegenerateKeysOptions options, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options, token);
    }

    public async Task<CommandResult> Show(AzRedisShowOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzRedisShowOptions(), token);
    }

    public async Task<CommandResult> Update(AzRedisUpdateOptions? options = default, CancellationToken token = default)
    {
        return await _command.ExecuteCommandLineTool(options ?? new AzRedisUpdateOptions(), token);
    }
}