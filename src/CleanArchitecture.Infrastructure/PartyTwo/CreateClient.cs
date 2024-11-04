using CleanArchitecture.Application.Flows;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Infrastructure.PartyTwo;

public class CreateClient() : ICreateClient
{
    public async Task<OutgoingMessage> Execute(IncomingMessage incomingMessage)
    {
        throw new NotImplementedException();
    }
}