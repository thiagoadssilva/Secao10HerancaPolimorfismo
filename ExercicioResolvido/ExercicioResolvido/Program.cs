using ExercicioResolvido.Entities;
using System.Globalization;

List<Employee> list = new List<Employee>();

Console.Write("Informe a quantidade de funcionários: ");
int amountEmployee = int.Parse(Console.ReadLine());

for (int i = 1; i <= amountEmployee; i++)
{
    Console.WriteLine($"Dados do #{i} Empregado :");
    Console.WriteLine();

    Console.Write("Funcionário é tercerizado? (y/n): ");
    string outsourced = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Nome: ");
    string name = Console.ReadLine();
    Console.WriteLine();

    Console.Write("Horas: ");
    int hours = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Valor por Horas: ");
    double veluePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    if (outsourced == "y")
    {
        Console.Write("Valor adicional: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new OutsourcedEmployee(name, hours, veluePerHours, additionalCharge));
    }
    else
    {
        list.Add(new Employee(name, hours, veluePerHours));
    }
}

Console.WriteLine("PAYMENTS");
foreach (Employee emp in list)
{
    Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2"), CultureInfo.InvariantCulture);
}