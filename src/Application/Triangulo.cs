namespace Application
{
    public class Triangulo
    {
        public static double CalcularPerimetro(double ladoA, double ladoB, double ladoC)
        {
            return ladoA + ladoB + ladoC;
        }

        public static double CalcularArea(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}
