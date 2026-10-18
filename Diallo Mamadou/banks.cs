public class Bank(string name)
{
    public string Name { get; set; } = name;
    public Dictionary<string, CurrentAccount> Accounts { get; } = new();

    public void AddAccount(CurrentAccount account)
    {
        if (!Accounts.TryAdd(account.Number, account))
            throw new InvalidOperationException($"Le compte {account.Number} existe déjà.");
    }

    public void DeleteAccount(string number)
    {
        if (!Accounts.Remove(number))
            throw new KeyNotFoundException($"Le compte {number} n'existe pas.");
    }
        public double GetBalance(string number)
    {
        if (!Accounts.TryGetValue(number, out var account))
            throw new KeyNotFoundException($"Le compte {number} n'existe pas.");

        return account.Balance;
    }
}

