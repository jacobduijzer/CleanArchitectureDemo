using CleanArchitecture.Domain;
using Refit;

namespace CleanArchitecture.Infrastructure.PartyOne;

public interface IApi 
{
   [Post("/post")]
   Task<string> AddDebtor([Body(BodySerializationMethod.Serialized)]Debtor debtor);
}