using CleanArchitecture.Application.Flows;
using CleanArchitecture.Infrastructure;

namespace CleanArchitecture.Api;

public static class PartyExtensions
{
  public static IServiceCollection AddPartyImplementations(this IServiceCollection services)
  {
    services.AddScoped<Infrastructure.PartyOne.CreateClient>();
    services.AddScoped<Infrastructure.PartyTwo.CreateClient>();
    services.AddScoped<IPartyDictionaries, PartyDictionaries>();
    return services;
  }
  
  public class PartyDictionaries(IServiceProvider serviceProvider) : IPartyDictionaries
  {
    public IFlow FlowForParty(string flow, string party)
    {
      return party switch
      {
        "PartyOne" => _partyOneDict[flow](serviceProvider),
        "PartyTwo" => _partyTwoDict[flow](serviceProvider),
        _ => throw new NotImplementedException()
      };
        
    }    
    
    private Dictionary<string, Func<IServiceProvider, IFlow>> _partyOneDict = new()
    {
      ["CreateClient"] = (sp) => sp.GetRequiredService<Infrastructure.PartyOne.CreateClient>(),
      // ["UpdateClient"] = (sp) => sp.GetRequiredService<PartyOne.UpdateClient>()
    };
    
    private Dictionary<string, Func<IServiceProvider, IFlow>> _partyTwoDict = new()
    {
      ["CreateClient"] = (sp) => sp.GetRequiredService<Infrastructure.PartyTwo.CreateClient>(),
      // ["UpdateClient"] = (sp) => sp.GetRequiredService<PartyTwo.UpdateClient>()
    };
  }
}