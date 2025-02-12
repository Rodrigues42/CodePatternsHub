using Investimentos.Application.Queries.Interfaces;

namespace Investimentos.Infrastructure.DataStore;

public class ExemploQueryStore : IExemploQueryStore
{
    public async Task<string> ConsultaIdExemplo(int id)
    {
        await Task.Delay(100);

        return $"Seu id é {id}";
    }
}
