var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Logging Middleware
app.Use(async (context, next) =>
{
    Console.WriteLine("Request: " + context.Request.Path);
    await next();
    Console.WriteLine("Response Status: " + context.Response.StatusCode);
});
app.Use(async (context, next) =>
{
    context.Response.Headers.Add(
        "Content-Security-Policy",
        "default-src 'self'; script-src 'self'; style-src 'self';"
    );

    await next();
});

// HTTPS redirect
app.UseHttpsRedirection();

// Serve static files
app.UseStaticFiles();

// Default page mapping
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();