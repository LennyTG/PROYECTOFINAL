using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestTriangulo
    {
        [Theory]
        [InlineData(3, 4, 5, 12)]
        [InlineData(6, 8, 10, 24)]
        public void CalcularPerimetro_DeberiaRetornarResultadoCorrecto(double ladoA, double ladoB, double ladoC, double perimetroEsperado)
        {
            double resultado = Triangulo.CalcularPerimetro(ladoA, ladoB, ladoC);
            Assert.Equal(perimetroEsperado, resultado);
        }

        [Theory]
        [InlineData(3, 4, 6)]
        [InlineData(6, 8, 24)]
        public void CalcularArea_DeberiaRetornarResultadoCorrecto(double baseTriangulo, double alturaTriangulo, double areaEsperada)
        {
            double resultado = Triangulo.CalcularArea(baseTriangulo, alturaTriangulo);
            Assert.Equal(areaEsperada, resultado);
        }
    }
}
