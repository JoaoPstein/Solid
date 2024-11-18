namespace Liskov.Substitution.Principle.Bad;

public class BankAccount{

    public virtual void WithDraw(decimal amount)
    {
        Console.Write($"Withdraw {amount} ");
    }
}

public class SavingsAccount : BankAccount
{
    private decimal Balance { get; set; }

    public override void WithDraw(decimal amount)
    {
        if(Balance < amount)
            throw new ApplicationException("Insufficient balance");

        Balance = amount;
        Console.Write($"Withdraw {amount} ");
    }
}
