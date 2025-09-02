var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/weatherforecast", () =>
{
    return new
    {
        Service = "ServiceA",
        Message = "Hello from ServiceA!"
    };
});

app.Run();
