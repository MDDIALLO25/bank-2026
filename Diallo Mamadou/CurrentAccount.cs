public class CurrentAccount(string number, Person owner)
{
    public string Number { get; set; } = number;
    public double Balance { get; private set; }
    public double CreditLine { get; set; }
    public Person Owner { get; set; } = owner;

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Le montant doit être positif.");

        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Le montant doit être positif.");

        if (Balance - amount < -CreditLine)
            throw new InvalidOperationException("Solde insuffisant.");

        Balance -= amount;
    }
}