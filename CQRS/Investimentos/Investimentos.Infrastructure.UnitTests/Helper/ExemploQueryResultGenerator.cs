using Investimentos.Application.Contracts.Exemplo;

namespace Investimentos.Infrastructure.UnitTests.Helper;

public static class ExemploQueryResultGenerator
{
    public static ExemploQueryResult GeneratorValidResult(int id)
    {
        return new()
        {
            Message = $"Seu id é {id}"
        };
    }
}
