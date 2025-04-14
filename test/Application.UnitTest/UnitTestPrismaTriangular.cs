using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestPrismaTriangular
    {
        [Theory]
        [InlineData(6, 10, 60)]
        [InlineData(12, 15, 180)]
        public void CalcularVolumen_DeberiaRetornarResultadoCorrecto(double areaBase, double alturaPrisma, double volumenEsperado)
        {
            double resultado = PrismaTriangular.CalcularVolumen(areaBase, alturaPrisma);
            Assert.Equal(volumenEsperado, resultado);
        }
    }
}
