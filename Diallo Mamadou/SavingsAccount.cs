using Bank2026.Models;
namespace Bank.Models;

public class SavingsAccount : Account
{
    public DateTime DateLastWithdraw { get; private set; }

    public SavingsAccount(
        string number,
        Person owner)
        : base(number, owner)
    {
    }

    public override void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException(nameof(amount));

        if (Balance < amount)
            throw new InvalidOperationException(
                "Solde insuffisant");

        DecreaseBalance(amount);

        DateLastWithdraw = DateTime.Now;
    }

    protected override double CalculInterest()
    {
        return Balance * 0.045;
    }
}