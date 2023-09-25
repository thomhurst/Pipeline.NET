﻿using ModularPipelines.Logging;

namespace ModularPipelines.Http;

public class LoggingHttpHandler : DelegatingHandler
{
    private readonly IModuleLoggerProvider _moduleLoggerProvider;

    public LoggingHttpHandler(IModuleLoggerProvider moduleLoggerProvider)
    {
        _moduleLoggerProvider = moduleLoggerProvider;
    }

    /// <inheritdoc/>
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var logger = _moduleLoggerProvider.GetLogger();

        await HttpLogger.PrintRequest(request, logger);

        var response = await base.SendAsync(request, cancellationToken);

        await HttpLogger.PrintResponse(response, logger);

        return response.EnsureSuccessStatusCode();
    }
}