using Xunit;
using Application;

namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
    {
        [Fact]
        public void CalculoDeAreaYVolumen_DeberiaSerCorrecto()
        {
            double baseTriangulo = 5.0;
            double alturaTriangulo = 12.0;
            double alturaPrisma = 10.0;

            double area = Triangulo.CalcularArea(baseTriangulo, alturaTriangulo);
            double volumen = PrismaTriangular.CalcularVolumen(area, alturaPrisma);

            Assert.Equal(30.0, area);
            Assert.Equal(300.0, volumen);
        }
    }
}
