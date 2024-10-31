using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure.Practiplan;

namespace CleanArchitecture.Infrastructure;

public class MessageHandlerFactory(
  IApi api)
{
  public IHandler Create(string message) =>
    message switch
    {
      "AddDebtor" => new AddDebtorHandler(api),
      "UpdateDebtor" => new UpdateUserHandler(api),
      _ => throw new ArgumentException("Invalid message type", nameof(message))
    };
}