using Microsoft.Extensions.Logging;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Modules;

namespace ModularPipelines.Engine.Executors.ModuleHandlers;

internal class HookHandler<T> : BaseHandler<T>, IHookHandler<T>
{
    public HookHandler(Module<T> module) : base(module)
    {
    }

    public async Task OnBeforeExecute(IPipelineContext context)
    {
        try
        {
            await Module.OnBeforeExecute(context);
        }
        catch (Exception exception)
        {
            Logger.LogError(exception, "Error in OnBeforeExecute");
            throw;
        }
    }

    public async Task OnAfterExecute(IPipelineContext context, ModuleResult<T> moduleResult)
    {
        try
        {
            await Module.OnAfterExecute(context, moduleResult);
        }
        catch (Exception exception)
        {
            Logger.LogError(exception, "Error in OnAfterExecute");
        }
    }
}