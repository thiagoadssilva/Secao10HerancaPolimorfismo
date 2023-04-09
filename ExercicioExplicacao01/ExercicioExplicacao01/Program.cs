using ExercicioExplicacao01.Entities;

//BusinessAccount businessAccount = new BusinessAccount(1010, "thiago", 100.50, 200);
//Console.WriteLine(businessAccount.Balance);
//businessAccount.Balance = 100; // Por conta do modificador de acesso não é permitido fazer qualquer alteração nesse atributo...

// Trabalhando com Upcasting e DownCasting
Account acc = new Account(1010, "thiago", 0.0);
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
}