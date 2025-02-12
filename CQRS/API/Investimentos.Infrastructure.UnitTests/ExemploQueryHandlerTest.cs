using Investimentos.Application.Queries.Exemplo;
using Investimentos.Application.Queries.Interfaces;
using Investimentos.Infrastructure.DataStore;
using Investimentos.Infrastructure.UnitTests.Helper;
using Moq;

namespace Investimentos.Infrastructure.UnitTests
{
    public class ExemploQueryHandlerTest
    {
        private readonly ExemploQueryHandler _exemploQueryHandler;
        private readonly Mock<IExemploQueryStore> _exemploQueryStore;

        public ExemploQueryHandlerTest()
        {
            _exemploQueryStore = new Mock<IExemploQueryStore>();
            _exemploQueryHandler = new ExemploQueryHandler(_exemploQueryStore.Object);
        }

        [Fact]
        public async Task ConsultaIdExemplo_ReturnSuccess()
        {
            var queryRequest = ExemploQueryRequestGenerator.GenerateValidQuery();
            var queryResult = ExemploQueryResultGenerator.GeneratorValidResult(queryRequest.Id);

            _exemploQueryStore.Setup(x => x.ConsultaIdExemplo(It.IsAny<int>())).ReturnsAsync(queryResult.Message);

            var response = await _exemploQueryHandler.Handle(queryRequest);

            Assert.Equal($"Seu id é {queryRequest.Id}", response.Message);
        }
    }
}