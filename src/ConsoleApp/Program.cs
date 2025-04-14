using Application;

class Program
{
    static void Main(string[] args)
    {
        double lado1 = 5.0;
        double lado2 = 6.0;
        double lado3 = 7.0;
        double baseTriangulo = 8.0;
        double alturaTriangulo = 9.0;
        double alturaPrisma = 15.0;

        double perimetro = Triangulo.CalcularPerimetro(lado1, lado2, lado3);
        double area = Triangulo.CalcularArea(baseTriangulo, alturaTriangulo);
        double volumen = PrismaTriangular.CalcularVolumen(area, alturaPrisma);

        Console.WriteLine($"Perímetro del triángulo: {perimetro} cm");
        Console.WriteLine($"Área del triángulo: {area} cm²");
        Console.WriteLine($"Volumen del prisma triangular: {volumen} cm³");
    }
}
