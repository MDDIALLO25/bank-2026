using Bank2026.Models;

Person p1 = new Person
{
    FirstName = "Mamadou",
    LastName = "Diallo",
    BirthDate = new DateTime(2000, 5, 10)
};

CurrentAccount compte1 = new CurrentAccount
{
    Number = "BE0001",
    CreditLine = 1000,
    Owner = p1
};

CurrentAccount compte2 = new CurrentAccount
{
    Number = "BE0002",
    CreditLine = 500,
    Owner = p1
};

compte1.Deposit(2000);
compte1.Withdraw(250);

compte2.Deposit(1500);

Bank bank = new Bank
{
    Name = "Ma Banque"
};

bank.AddAccount(compte1);
bank.AddAccount(compte2);

Console.WriteLine($"Solde compte 1 : {bank.GetBalance("BE0001")}");
Console.WriteLine($"Solde compte 2 : {bank.GetBalance("BE0002")}");

Console.WriteLine($"Total de {p1} : {bank.GetTotalBalance(p1)}");