
using System.Globalization;
using ExercicioProposto01.Entities;
using ExercicioProposto01.Entities.Enums;

List<Product> list = new List<Product>();

Console.Write("Entre com a quantidade de produtos: ");
int quantityProducts = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantityProducts; i++)
{
    Console.WriteLine($"Dados do #{i} Produto:");
    Console.Write("Esse Produto é Importado, usado ou comum (I/U/C): ");
    string typeProduct = Console.ReadLine();
    Console.Write("Nome: ");
    string name = Console.ReadLine();
    Console.Write("Preço: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Status do produto (A/I): ");
    string status = Console.ReadLine();
    
    if (typeProduct == "I")
    {
        TypeProduct tp = TypeProduct.Imported;
        StatusProduct st = StatusProduct.Ativo;
        Console.Write("Qual a taxa da alfandega:");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new ImportedProduct(name, price, st, tp, customsFee));            
    }else if(typeProduct == "U")
    {
        TypeProduct tp = TypeProduct.Used;
        StatusProduct st = StatusProduct.Inativo;
        Console.Write("Qual a data de fabricação (DD/MM/YYYY)");
        DateTime date = DateTime.Parse(Console.ReadLine());

        list.Add(new UsedProduct(name, price, st, tp, date));
    }
    else
    {
        TypeProduct tp = TypeProduct.Commin;
        StatusProduct st = StatusProduct.Ativo;
        list.Add(new Product(name, price, st, tp));
    }

}

Console.WriteLine();
Console.WriteLine("Etiquetas de Preços:");

foreach(Product product in list)
{
    Console.WriteLine(product.PriceTag());
}