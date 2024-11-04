using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Flows;

public interface IFlow
{
    Task<OutgoingMessage> Execute(IncomingMessage incomingMessage);
}