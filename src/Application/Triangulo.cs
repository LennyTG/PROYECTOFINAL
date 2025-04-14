namespace Application
{
    public class Triangulo
    {
        public static double CalcularPerimetro(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        public static double CalcularArea(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }
    }
}
