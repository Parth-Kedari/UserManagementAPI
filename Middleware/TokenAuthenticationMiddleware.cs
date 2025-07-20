using System.Text.Json;

public class TokenAuthenticationMiddleware
{
    private readonly RequestDelegate _next;

    public TokenAuthenticationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
{
    var path = context.Request.Path.Value;

    // Allow Swagger & health checks without authentication
    if (path.StartsWith("/swagger") || path.StartsWith("/favicon.ico"))
    {
        await _next(context);
        return;
    }

    var token = context.Request.Headers["Authorization"].FirstOrDefault();

    if (string.IsNullOrEmpty(token) || token != "Bearer your_secure_token_here")
    {
        context.Response.StatusCode = 401;
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(JsonSerializer.Serialize(new { error = "Unauthorized" }));
        return;
    }

    await _next(context);
}

}
