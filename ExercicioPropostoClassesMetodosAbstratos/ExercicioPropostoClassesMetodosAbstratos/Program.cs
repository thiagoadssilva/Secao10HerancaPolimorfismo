using ExercicioPropostoClassesMetodosAbstratos.Entities;
using System.Globalization;

List<TaxPayer> taxPayers = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= n; i++)
{
    Console.Write($"Tax payer #{i} data:");
    Console.WriteLine();
    Console.Write("Individual or company (i/c)? ");
    string companyIndividual = Console.ReadLine();
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    if (companyIndividual == "i")
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberEmployee = int.Parse(Console.ReadLine());
        taxPayers.Add(new Company(name, anualIncome, numberEmployee));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
double sum = 0;
foreach (TaxPayer t in taxPayers)
{
    sum += t.Tax();
    Console.WriteLine($"{t.Name}: ${t.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
    Console.WriteLine("TOTAL TAXES: $" + t.Tax);
}

Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));



