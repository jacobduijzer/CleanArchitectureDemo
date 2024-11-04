using Microsoft.AspNetCore.Mvc.Testing;
using Reqnroll;

namespace CleanArchitecture.Specs;

[Binding]
public class Hooks
{
    [BeforeScenario(Order = 0)]
    public static void StartWebApplication(ScenarioContext scenarioContext)
    {
        var webApp = new WebApplicationFactory<Program>();
        var webAppContext = new WebApplicationContext(webApp);
        webAppContext.Start();
        scenarioContext.ScenarioContainer.RegisterInstanceAs(webAppContext);
    }
}