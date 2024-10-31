using Microsoft.AspNetCore.Mvc.Testing;

namespace CleanArchitecture.Specs;

public class WebApplicationContext(WebApplicationFactory<Program> webApp)
{
    public HttpClient Client { get; set; } = null!;
    
    public void Start()
    {
        Client = webApp.CreateClient();
    }
}