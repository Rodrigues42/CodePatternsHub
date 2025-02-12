using Investimentos.Application.Contracts.Exemplo;

namespace Investimentos.Infrastructure.UnitTests.Helper;

public static class ExemploQueryRequestGenerator
{
    public static ExemploQueryRequest GenerateValidQuery()
    {
        return new()
        {
            Id = 1
        };
    }
}
