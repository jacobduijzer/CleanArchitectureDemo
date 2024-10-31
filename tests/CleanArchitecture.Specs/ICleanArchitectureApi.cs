using Refit;

namespace CleanArchitecture.Specs;

public interface ICleanArchitectureApi
{
   [Post("/")]
   Task AddMessage(string message);
}