using Xunit;
using Application;

namespace Application.UnitTest
{
    public class PrismaTriangularTests
    {
        [Theory]
        [InlineData(6, 10, 60)]
        [InlineData(30, 12, 360)]
        [InlineData(49, 15, 735)]
        [InlineData(64, 20, 1280)]
        [InlineData(81, 25, 2025)]
        public void TestCalcularVolumen(double areaBase, double altura, double esperado)
        {
            double resultado = PrismaTriangular.CalcularVolumen(areaBase, altura);
            Assert.Equal(esperado, resultado);
        }
    }
}
