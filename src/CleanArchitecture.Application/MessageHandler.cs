using CleanArchitecture.Domain;

namespace CleanArchitecture.Application;

public class MessageHandler(IFlowFactory flowFactory)
{
    public async Task<OutgoingMessage> Handle(IncomingMessage incomingMessage)
    {
        var flow = flowFactory.Create(incomingMessage);
        return await flow.Execute(incomingMessage);
    }
}