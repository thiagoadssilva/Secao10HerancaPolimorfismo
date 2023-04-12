using ExercicioExplicacao01.Entities;
using System.ComponentModel;
using System.Globalization;

List<Account> list = new List<Account>();

list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.001));
list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

double sum = 0;

foreach (Account account in list)
{
    sum += account.Balance;
}

Console.WriteLine("Total soma: " + sum.ToString("F2"), CultureInfo.InvariantCulture);

foreach (Account account in list)
{
    account.Withdraw(10.0);
}

foreach (Account account in list)
{
    Console.WriteLine("Saldo das contas atualizado "
        + account.Number
        + ": "
        + account.Balance.ToString("F2"), CultureInfo.InvariantCulture);
}

/*Account contaUm = new Account(1, "thiago", 500.0);
Account contaDois = new SavingsAccount(2, "Dineia", 500.0, 0.01);

contaUm.Withdraw(10.0);
contaDois.Withdraw(10.0);

Console.WriteLine(contaUm.Balance);
Console.WriteLine(contaDois.Balance);*/

//BusinessAccount businessAccount = new BusinessAccount(1010, "thiago", 100.50, 200);
//Console.WriteLine(businessAccount.Balance);
//businessAccount.Balance = 100; // Por conta do modificador de acesso não é permitido fazer qualquer alteração nesse atributo...

// Trabalhando com Upcasting e DownCasting
/*Account acc = new Account(1010, "thiago", 0.0);
BusinessAccount bacc = new BusinessAccount(1011, "Dineia", 0.0, 500.00);

// UPCASTING

Account acc1 = bacc;
Account acc2 = new BusinessAccount(10101, "Bento", 0.0, 200.0);
Account acc3 = new SavingsAccount(10020, "Mel", 0.0, 0.001);

// DOWNCASTING
BusinessAccount acc4 = (BusinessAccount)acc2;
acc4.Loan(100.0);
//BusinessAccount acc5 = (BusinessAccount)acc3; // vai da erro em tempo de execução

// Antes de fazer qualquer DOWNCASTING é necessário validar os objetos
if (acc3 is BusinessAccount)
{
    //BusinessAccount acc5 = (BusinessAccount)acc3;
    BusinessAccount acc5 = acc3 as BusinessAccount; // Aqui é uma outra maneira de fazer o casting
    acc5.Loan(200.0);
    Console.WriteLine("Loan");
}

if (acc3 is SavingsAccount)
{
    //SavingsAccount acc5 = (SavingsAccount)acc3;
    SavingsAccount acc5 = acc3 as SavingsAccount; // Aqui é uma outra maneira de fazer o casting
    acc5.UpdateBalance();
    Console.WriteLine("Update!");
}*/