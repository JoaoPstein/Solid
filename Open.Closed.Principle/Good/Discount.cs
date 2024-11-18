using Open.Close.Principle.Bad;

namespace Open.Close.Principle.Good;

public abstract class Discount
{
    public abstract decimal Calculate(decimal price);
}

public class EletronicsDiscount : Discount
{
    public override decimal Calculate(decimal price)
    => price * 0.5m;
}

public class HealthDiscount : Discount
{
    public override decimal Calculate(decimal price)
        => price * 0.4m;
}