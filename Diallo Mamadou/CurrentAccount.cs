namespace Bank2026.Models;

public class CurrentAccount
{
    public string Number { get; set; }

    public double Balance { get; private set; }

    public double CreditLine { get; set; }

    public Person Owner { get; set; }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Le montant doit être positif.");

        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Le montant doit être positif.");

        if (Balance - amount < -CreditLine)
            throw new InvalidOperationException("Crédit dépassé.");

        Balance -= amount;
    }
}