using System.Text.Json;
using CleanArchitecture.Application.Flows;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Infrastructure.PartyOne;

public class CreateClient(IApi api) : ICreateClient
{
    public async Task<OutgoingMessage> Execute(IncomingMessage incomingMessage)
    {
        var result = await api.AddDebtor(new Debtor
        {
            Id = Guid.NewGuid(),
            Name = incomingMessage.Name
        });
        using JsonDocument doc = JsonDocument.Parse(result);
        if (doc.RootElement.TryGetProperty("json", out var json) &&
            json.TryGetProperty("id", out var idString))
        {
            return new OutgoingMessage
            {
                Id = Guid.Parse(idString.GetString()!),
                Message = "Client created successfully"
            };
        }

        throw new Exception("Failed to receive data");
    }
}