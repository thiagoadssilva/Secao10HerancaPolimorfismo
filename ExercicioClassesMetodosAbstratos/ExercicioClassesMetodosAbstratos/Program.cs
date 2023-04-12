using ExercicioClassesMetodosAbstratos.Entities;
using ExercicioClassesMetodosAbstratos.Entities.Enums;
using System.Globalization;

List<Shape> list = new List<Shape>();

Console.Write("Entre com a quantidade de figuras:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Dados da figura numero #{i}");
    Console.WriteLine();

    Console.Write("Retangulo ou Circulo (R / C): ");
    char ch = char.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Informe a cor (Black, Blue e Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());
    Console.WriteLine();

    if (ch == 'R')
    {
        Console.Write("Largura: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Altura: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Rectangle(width, height, color));
    }
    else
    {
        Console.Write("Raio: ");
        double radius = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Circle(radius, color));
    }
}

Console.WriteLine();
Console.WriteLine("Areas das Figuras:");

foreach (Shape shape in list)
{
    Console.WriteLine(shape.Area().ToString("F2"), CultureInfo.InvariantCulture);
}


