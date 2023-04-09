using ExercicioExplicacao01.Entities;

BusinessAccount businessAccount = new BusinessAccount(1010, "thiago", 100.50, 200);
Console.WriteLine(businessAccount.Balance);
businessAccount.Balance = 100; // Por conta do modificador de acesso não é permitido fazer qualquer alteração nesse atributo...