namespace Bank2026.Models;

public class Bank
{
    public string Name { get; set; }

    public Dictionary<string, CurrentAccount> Accounts { get; }
        = new Dictionary<string, CurrentAccount>();

    public void AddAccount(CurrentAccount account)
    {
        if (account == null)
            throw new ArgumentNullException(nameof(account));

        Accounts.Add(account.Number, account);
    }

    public void DeleteAccount(string number)
    {
        Accounts.Remove(number);
    }

    public double GetBalance(string number)
    {
        if (Accounts.ContainsKey(number))
            return Accounts[number].Balance;

        throw new KeyNotFoundException("Compte introuvable.");
    }

    public double GetTotalBalance(Person owner)
    {
        return Accounts.Values
            .Where(a => a.Owner == owner)
            .Sum(a => a.Balance);
    }
}