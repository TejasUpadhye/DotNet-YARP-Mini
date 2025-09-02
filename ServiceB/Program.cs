var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/weatherforecast", () =>
{
    return new
    {
        Service = "ServiceB",
        Message = "Hello from ServiceB!"
    };
});

app.Run();
