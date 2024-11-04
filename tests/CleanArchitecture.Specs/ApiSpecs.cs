using CleanArchitecture.Domain;
using Reqnroll;

namespace CleanArchitecture.Specs;

[Binding]
public class ApiSpecs(
    WebApplicationContext webAppContext,
    ScenarioContext scenarioContext)
{
    private const string ClientName = "ClientName";
    private const string Result = "Result";

    [Given(@"I want to create a new client named '(.*)'")]
    public void GivenIWantToCreateANewClientNamed(string clientName)
    {
        scenarioContext.Add(ClientName, clientName);
    }

    [When(@"I send a message to the api to create this new client")]
    public async Task WhenISendAMessageToTheApiToCreateThisNewClient()
    {
        var result = await webAppContext.Api
            .AddMessage(new IncomingMessage("CreateClient",
                scenarioContext.Get<string>("PartyName"),
                scenarioContext.Get<string>(ClientName)));

        scenarioContext.Add(Result, result);
    }

    [Then(@"a success message ""(.*)""")]
    public void ThenIShouldReceiveASuccessMessage(string message)
    {
        Assert.Equal(message, scenarioContext.Get<OutgoingMessage>(Result).Message);
    }

    [Then(@"I should receive a valid, new id")]
    public void ThenIShouldReceiveAValidNewId()
    {
        Assert.True(scenarioContext.Get<OutgoingMessage>(Result).Id != Guid.Empty);
    }

    [Given(@"I want to create it in the system of '(.*)'")]
    public void GivenIWantToCreateItInTheSystemOfPartyTwo(string partyName)
    {
        scenarioContext.Add("PartyName", partyName);
    }
}