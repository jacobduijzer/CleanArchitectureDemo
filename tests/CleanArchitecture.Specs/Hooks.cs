using Microsoft.AspNetCore.Mvc.Testing;
using Reqnroll;

namespace CleanArchitecture.Specs;

[Binding]
public class Hooks
{
    [BeforeScenario(Order = 0)]
    public static void StartWebApplication(ScenarioContext scenarioContext)
    {
        // Set up Web application
        var webApp = new WebApplicationFactory<Program>();
        //     .WithWebHostBuilder(c => c.UseConfiguration(new ConfigurationBuilder()
        //         .AddInMemoryCollection(new Dictionary<string, string?>
        //         {
        //         }.AsReadOnly())
        //         .Build()));
        
        // We create a wrapper so we can store responses when doing requests. This is useful for assertions.
        var webAppContext = new WebApplicationContext(webApp);
        webAppContext.Start();
        scenarioContext.ScenarioContainer.RegisterInstanceAs(webAppContext);
    }
}