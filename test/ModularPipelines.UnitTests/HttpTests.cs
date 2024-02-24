using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ModularPipelines.Http;
using ModularPipelines.Options;
using ModularPipelines.TestHelpers;
using TUnit.Assertions.Extensions;
using Vertical.SpectreLogger.Options;

namespace ModularPipelines.UnitTests;

public class HttpTests : TestBase
{
    [Test]
    public async Task Can_Send_Request_With_String_To_Request_Implicit_Conversion()
    {
        var http = await GetService<IHttp>();

        await http.SendAsync("https://www.github.com");
    }

    [Test]
    public async Task When_Log_Request_False_Then_Do_Not_Log_Request()
    {
        var file = Path.Combine(Environment.CurrentDirectory, Guid.NewGuid().ToString("N") + ".txt");

        var result = await GetService<IHttp>((_, collection) =>
        {
            collection.AddLogging(builder =>
            {
                collection.Configure<SpectreLoggerOptions>(options => options.MinimumLogLevel = LogLevel.Information);
                collection.Configure<LoggerFilterOptions>(options => options.MinLevel = LogLevel.Information);
                builder.AddFile(file);
            });
        });

        await result.T.SendAsync(new HttpOptions(new HttpRequestMessage(HttpMethod.Get, "https://www.github.com"))
        {
            LoggingType = HttpLoggingType.Response,
        });

        await result.Host.DisposeAsync();

        var logFile = await File.ReadAllTextAsync(file);
        await Assert.That(logFile).Does.Contain("INFO	[ModularPipelines.Http.ResponseLoggingHttpHandler]");
        await Assert.That(logFile).Does.Not.Contain("---Request---");
        await Assert.That(logFile).Does.Not.Contain("GET https://www.github.com/ HTTP/1.1");
        await Assert.That(logFile).Does.Contain("---Response---");
        await Assert.That(logFile).Does.Contain("Server: GitHub.com");
    }

    [Test]
    public async Task When_Log_Response_False_Then_Do_Not_Log_Request()
    {
        var file = Path.Combine(Environment.CurrentDirectory, Guid.NewGuid().ToString("N") + ".txt");

        var result = await GetService<IHttp>((_, collection) =>
        {
            collection.AddLogging(builder =>
            {
                collection.Configure<SpectreLoggerOptions>(options => options.MinimumLogLevel = LogLevel.Information);
                collection.Configure<LoggerFilterOptions>(options => options.MinLevel = LogLevel.Information);
                builder.AddFile(file);
            });
        });

        await result.T.SendAsync(new HttpOptions(new HttpRequestMessage(HttpMethod.Get, "https://www.github.com"))
        {
            LoggingType = HttpLoggingType.Request,
        });

        await result.Host.DisposeAsync();

        var logFile = await File.ReadAllTextAsync(file);
        await Assert.That(logFile).Does.Contain("INFO	[ModularPipelines.Http.RequestLoggingHttpHandler]");
        await Assert.That(logFile).Does.Contain("---Request---");
        await Assert.That(logFile).Does.Contain("GET https://www.github.com/ HTTP/1.1");
        await Assert.That(logFile).Does.Not.Contain("---Response---");
        await Assert.That(logFile).Does.Not.Contain("Server: GitHub.com");
    }

    [DataDrivenTest(true)]
    [DataDrivenTest(false)]
    public async Task Assert_LoggingHttpClient_Logs_As_Expected(bool customHttpClient)
    {
        var file = Path.Combine(Environment.CurrentDirectory, Guid.NewGuid().ToString("N") + ".txt");

        var result = await GetService<IHttp>((_, collection) =>
        {
            collection.AddLogging(builder =>
            {
                collection.Configure<SpectreLoggerOptions>(options => options.MinimumLogLevel = LogLevel.Information);
                collection.Configure<LoggerFilterOptions>(options => options.MinLevel = LogLevel.Information);
                builder.AddFile(file);
            });
        });

        if (!customHttpClient)
        {
            var loggingClient = result.T.GetLoggingHttpClient();

            await loggingClient.GetAsync("https://www.github.com");
        }
        else
        {
            await result.T.SendAsync(new HttpOptions(new HttpRequestMessage(HttpMethod.Get, "https://www.github.com"))
            {
                HttpClient = new HttpClient()
            });
        }

        await result.Host.DisposeAsync();

        var logFile = await File.ReadAllTextAsync(file);
        await Assert.That(logFile).Does.Contain("INFO	[ModularPipelines.Http.");
        await Assert.That(logFile).Does.Contain("---Request---");
        await Assert.That(logFile).Does.Contain("GET https://www.github.com/ HTTP/1.1");
        await Assert.That(logFile).Does.Contain("---Response---");
        await Assert.That(logFile).Does.Contain("Headers");
        await Assert.That(logFile).Does.Contain("Server: GitHub.com");
        await Assert.That(logFile).Does.Contain("Body");
        await Assert.That(logFile).Does.Contain("---Duration---");
        await Assert.That(logFile).Does.Contain("---HTTP Status Code---");

        var logFileLines = (await File.ReadAllLinesAsync(file)).ToList();

        var indexOfRequest = logFileLines.FindIndex(x => x.Contains("---Request---"));
        var indexOfStatusCode = logFileLines.FindIndex(x => x.Contains("---HTTP Status Code---"));
        var indexOfDuration = logFileLines.FindIndex(x => x.Contains("---Duration---"));
        var indexOfResponse = logFileLines.FindIndex(x => x.Contains("---Response---"));
        
        await Assert.Multiple(() =>
        {
            Assert.That(indexOfRequest).Is.LessThan(indexOfStatusCode);
            Assert.That(indexOfStatusCode).Is.LessThan(indexOfDuration);
            Assert.That(indexOfDuration).Is.LessThan(indexOfResponse);
        });
    }
}