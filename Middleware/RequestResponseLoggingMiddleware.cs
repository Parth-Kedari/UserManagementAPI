public class RequestResponseLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

    public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        var request = context.Request;
        _logger.LogInformation("Incoming Request: {method} {url}", request.Method, request.Path);

        await _next(context); // Call the next middleware

        var response = context.Response;
        _logger.LogInformation("Outgoing Response: {statusCode}", response.StatusCode);
    }
}
