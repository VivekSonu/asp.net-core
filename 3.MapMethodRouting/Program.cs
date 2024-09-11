var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//this below method of routing are only suitable for simple string output
//app.Map("/Home", () => "Hello World!");//it works with all types-get,post,put etc
//app.MapGet("/", () => "Hello World! - GET");
//app.MapPost("/", () => "Hello World! - POST");
//app.MapPut("/", () => "Hello World! - PUT");
//app.MapGet("/", () => "Hello World! - GET");

//for routing for complex logic implementation
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is home Page...GET");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is home Page...POST");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is home Page...PUT");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is home Page...DELETE");
    });
});
//for "/" route
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page Not Found..");
});




app.Run();
