var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Welcome to asp.net core \n");
    await next(context);
});

app.Run(async (context) =>
{
    //await Task.Delay(10000); // Pauses here for 1 second
    await context.Response.WriteAsync("Vivek");
});//the run method does not allow to run the next middlleware, if you want to execute the next middleware use the "Use" method

app.Run();
