namespace CleanArchitecture.Domain;

public record struct IncomingMessage(string Action, string Party, string Name);