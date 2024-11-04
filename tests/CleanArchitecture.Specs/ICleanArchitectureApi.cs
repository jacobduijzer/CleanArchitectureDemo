using CleanArchitecture.Domain;
using Refit;

namespace CleanArchitecture.Specs;

public interface ICleanArchitectureApi
{
   [Post("/")]
   Task<OutgoingMessage> AddMessage([Body(BodySerializationMethod.Serialized)]IncomingMessage incomingMessage);
}