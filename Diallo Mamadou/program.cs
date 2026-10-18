var person = new Person
{
    FirstName = "Mamadou",
    LastName = "Diallo",
    BirthDate = new DateTime(1990, 1, 1)
};

Console.WriteLine($"{person.FirstName} {person.LastName}, né le {person.BirthDate:dd/MM/yyyy}");

var account = new CurrentAccount("BE01", person) { CreditLine = 500 };

account.Deposit(1000);
account.Withdraw(1200);
Console.WriteLine($"Solde : {account.Balance}");

try
{
    account.Withdraw(400);
}
catch (InvalidOperationException e)
{
    Console.WriteLine($"Refusé : {e.Message}");
}

var bank = new Bank("Ma Banque");
bank.AddAccount(account);
Console.WriteLine($"Ma Banque : {bank.Accounts.Count} compte(s)");
Console.WriteLine($"Solde de BE01 : {bank.GetBalance("BE01")}");

foreach (KeyValuePair<string, CurrentAccount> pair in bank.Accounts)
    Console.WriteLine($"{pair.Key} -> {pair.Value.Balance}");

bank.DeleteAccount("BE01");
Console.WriteLine($"Après suppression : {bank.Accounts.Count} compte(s)");