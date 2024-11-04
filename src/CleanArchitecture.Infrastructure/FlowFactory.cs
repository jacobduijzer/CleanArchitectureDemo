using CleanArchitecture.Application;
using CleanArchitecture.Application.Flows;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Infrastructure;

public class FlowFactory(IPartyDictionaries partyDictionaries) : IFlowFactory
{
    public IFlow Create(IncomingMessage incomingMessage) =>
        partyDictionaries.FlowForParty(incomingMessage.Action, incomingMessage.Party);
}
