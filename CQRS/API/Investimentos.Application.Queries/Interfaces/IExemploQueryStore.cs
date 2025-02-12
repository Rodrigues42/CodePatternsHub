namespace Investimentos.Application.Queries.Interfaces;

public interface IExemploQueryStore
{
    Task<string> ConsultaIdExemplo(int id);
}
