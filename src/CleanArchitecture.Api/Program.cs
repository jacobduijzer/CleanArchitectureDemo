using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Infrastructure.Practiplan;
using Refit;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<MessageHandlerFactory>();
builder.Services
    .AddRefitClient<IApi>()
    .ConfigureHttpClient(c =>
        c.BaseAddress = new Uri("https://reqbin.com"));

var app = builder.Build();

// TODO: add data / message
app.MapPost("/", async (
    string message,
    MessageHandlerFactory messageHandlerFactory) =>
{
    IHandler handler = messageHandlerFactory.Create(message);
    await handler.Handler();

    return Results.Ok();
}).WithName("PostMessage");

app.Run();

public partial class Program
{
}