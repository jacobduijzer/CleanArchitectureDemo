Feature: Testing my api's
    
    Scenario: Sending a request to create a new client in the system of PartyOne
        Given I want to create a new client named 'Hank'
        And I want to create it in the system of 'PartyOne'
        When I send a message to the api to create this new client
        Then I should receive a valid, new id 
        And a success message "Client created successfully"
        
        
    Scenario: Sending a request to create a new client in the system of PartyTwo
        Given I want to create a new client named 'Hank'
        And I want to create it in the system of 'PartyTwo'
        When I send a message to the api to create this new client
        Then I should receive a valid, new id 
        And a success message "Client created successfully"