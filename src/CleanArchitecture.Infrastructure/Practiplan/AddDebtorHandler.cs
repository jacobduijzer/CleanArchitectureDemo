using CleanArchitecture.Application;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Infrastructure.Practiplan;

public class AddDebtorHandler(IApi api) : IHandler
{
    public async Task Handler()
    {
        // TODO: add data
        await api.AddDebtor(new Debtor());
    }
}