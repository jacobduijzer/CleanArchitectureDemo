using CleanArchitecture.Application.Flows;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Infrastructure.PartyOne;

public class UpdateClient(IApi api) : ICreateClient
{
    public Task<OutgoingMessage> Execute(IncomingMessage incomingMessage)
    {
        throw new NotImplementedException();
    }
}