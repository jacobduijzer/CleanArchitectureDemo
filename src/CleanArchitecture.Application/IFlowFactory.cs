using CleanArchitecture.Application.Flows;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application;

public interface IFlowFactory
{
    IFlow Create(IncomingMessage incomingMessage);
}