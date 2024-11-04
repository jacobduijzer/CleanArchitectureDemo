using CleanArchitecture.Application.Flows;

namespace CleanArchitecture.Infrastructure;

public interface IPartyDictionaries
{
    IFlow FlowForParty(string flow, string party);
}