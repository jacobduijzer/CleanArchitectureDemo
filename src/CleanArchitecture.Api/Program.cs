using CleanArchitecture.Api;
using CleanArchitecture.Application;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure;
using Refit;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<MessageHandler>();
builder.Services.AddScoped<IFlowFactory, FlowFactory>();
builder.Services.AddPartyImplementations();

builder.Services
    .AddRefitClient<CleanArchitecture.Infrastructure.PartyOne.IApi>()
    .ConfigureHttpClient(c =>
        c.BaseAddress = new Uri("https://httpbin.org"));

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app
    .MapPost("/", async (
        IncomingMessage message,
        MessageHandler messageHandler) =>
    {
        var outgoing = await messageHandler.Handle(message);
        return Results.Ok(outgoing);
    })
    .WithName("PostMessage")
    .WithOpenApi();

app.Run();

public partial class Program { }