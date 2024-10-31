using Reqnroll;

namespace CleanArchitecture.Specs;

[Binding]
public class ApiSpecs(WebApplicationContext webAppContext)
{
    [Given(@"i do something")]
    public async Task GivenIDoSomething()
    {
        var api = Refit.RestService.For<ICleanArchitectureApi>(webAppContext.Client);
        await api.AddMessage("AddDebtor");
    }
}