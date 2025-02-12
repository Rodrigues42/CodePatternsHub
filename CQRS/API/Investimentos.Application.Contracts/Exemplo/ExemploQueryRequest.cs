using MediatR;
namespace Investimentos.Application.Contracts.Exemplo;

public class ExemploQueryRequest : IRequest<ExemploQueryResult>
{
    public required int Id { get; set; }
}
