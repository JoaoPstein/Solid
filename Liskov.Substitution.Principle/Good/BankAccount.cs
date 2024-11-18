namespace Liskov.Substitution.Principle.Good;

public abstract class BankAccount
{
    public decimal Balance { get; protected set; }
    public abstract void WithDraw(decimal amount);
}

public class CheckingAccount : BankAccount
{
    public override void WithDraw(decimal amount)
    {
        throw new NotImplementedException();
    }
}

public class SavingsAccount : BankAccount
{
    public override void WithDraw(decimal amount)
    {
        throw new NotImplementedException();
    }
}