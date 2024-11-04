using Microsoft.AspNetCore.Mvc.Testing;

namespace CleanArchitecture.Specs;

public class WebApplicationContext(WebApplicationFactory<Program> webApp)
{
    public ICleanArchitectureApi Api { get; set; }
    
    public void Start()
    {
        Api = Refit.RestService.For<ICleanArchitectureApi>(webApp.CreateClient());
    }
}