public class CurrentAccount(string number, Person owner) : Account(number, owner)
{
    public double CreditLine { get; set; }

    protected override double MinimumBalance => -CreditLine;
}