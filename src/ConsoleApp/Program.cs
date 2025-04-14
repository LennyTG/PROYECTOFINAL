using Application;

public class Program
{
    static void Main(string[] args)
    {
        double ladoA = 5.0;
        double ladoB = 6.0;
        double ladoC = 7.0;
        double baseTriangulo = 8.0;
        double alturaTriangulo = 9.0;
        double alturaPrisma = 15.0;

        double perimetro = Triangulo.CalcularPerimetro(ladoA, ladoB, ladoC);
        double area = Triangulo.CalcularArea(baseTriangulo, alturaTriangulo);
        double volumen = PrismaTriangular.CalcularVolumen(area, alturaPrisma);

        Console.WriteLine($"Perímetro del triángulo: {perimetro} cm");
        Console.WriteLine($"Área del triángulo: {area} cm²");
        Console.WriteLine($"Volumen del prisma triangular: {volumen} cm³");
    }
}
