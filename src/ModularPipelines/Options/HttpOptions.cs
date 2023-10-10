using ModularPipelines.Http;

namespace ModularPipelines.Options;

public record HttpOptions(HttpRequestMessage HttpRequestMessage)
{
    /// <summary>
    /// Gets and sets an optional HttpClient for handling the request.
    /// </summary>
    public HttpClient? HttpClient { get; init; }

    /// <summary>
    /// Gets and sets the logging for the HTTP request.
    /// </summary>
    public HttpLoggingType LoggingType { get; init; } = HttpLoggingType.RequestAndResponse;

    public static implicit operator HttpOptions(HttpRequestMessage requestMessage) => new(requestMessage);

    public static implicit operator HttpOptions(Uri uri) => new HttpRequestMessage(HttpMethod.Get, uri);

    public static implicit operator HttpOptions(string uri) => new Uri(uri, UriKind.RelativeOrAbsolute);
}