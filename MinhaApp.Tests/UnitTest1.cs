using Xunit;
using MinhaApp;

namespace MinhaApp.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar_DeveRetornarSomaCorreta()
        {
            int resultado = Calculadora.Somar(2, 3);
            Assert.Equal(5, resultado);
        }
    }
}
