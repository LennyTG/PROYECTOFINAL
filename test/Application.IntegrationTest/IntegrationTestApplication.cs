using Xunit;
using Application;

namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
    {
        [Fact]
        public void TestArea()
        {
            double baseTriangulo = 5.0;
            double altura = 12.0;
            double area = Triangulo.CalcularArea(baseTriangulo, altura);
            Assert.Equal(30.0, area, 2);
        }

        [Fact]
        public void TestVolumen()
        {
            double areaBase = 30.0;
            double altura = 10.0;
            double volumen = PrismaTriangular.CalcularVolumen(areaBase, altura);
            Assert.Equal(300.0, volumen, 2);
        }
    }
}
