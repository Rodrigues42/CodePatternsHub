using Investimentos.Application.Contracts.Exemplo;
using Investimentos.Application.Queries.Interfaces;
using MediatR;

namespace Investimentos.Application.Queries.Exemplo;

public class ExemploQueryHandler : IRequestHandler<ExemploQueryRequest, ExemploQueryResult>
{
    private readonly IExemploQueryStore _exemploQueryStore;

    public ExemploQueryHandler
    (
        IExemploQueryStore exemploQueryStore
    )
    {
        _exemploQueryStore = exemploQueryStore;
    }

    public async Task<ExemploQueryResult> Handle(ExemploQueryRequest queryRequest, CancellationToken cancellationToken = default)
    {
        var messageId = await _exemploQueryStore.ConsultaIdExemplo(queryRequest.Id);

        return new()
        {
            Message = messageId
        };
    }
}
