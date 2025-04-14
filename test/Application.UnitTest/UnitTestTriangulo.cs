using Xunit;
using Application;

namespace Application.UnitTest
{
    public class TrianguloTests
    {
        [Theory]
        [InlineData(3, 4, 5, 12)]
        [InlineData(5, 12, 13, 30)]
        [InlineData(7, 24, 25, 56)]
        [InlineData(8, 15, 17, 40)]
        [InlineData(9, 40, 41, 90)]
        public void TestCalcularPerimetro(double ladoA, double ladoB, double ladoC, double esperado)
        {
            double resultado = Triangulo.CalcularPerimetro(ladoA, ladoB, ladoC);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(3, 4, 6)]
        [InlineData(5, 12, 30)]
        [InlineData(7, 14, 49)]
        [InlineData(8, 16, 64)]
        [InlineData(9, 18, 81)]
        public void TestCalcularArea(double baseTriangulo, double altura, double esperado)
        {
            double resultado = Triangulo.CalcularArea(baseTriangulo, altura);
            Assert.Equal(esperado, resultado);
        }
    }
}
