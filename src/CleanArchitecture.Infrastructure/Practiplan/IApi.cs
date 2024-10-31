using CleanArchitecture.Domain;
using Refit;

namespace CleanArchitecture.Infrastructure.Practiplan;

public interface IApi 
{
   [Post("/echo/post/json")]
   Task AddDebtor(Debtor debtor);
}