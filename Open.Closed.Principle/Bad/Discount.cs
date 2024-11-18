namespace Open.Close.Principle.Bad;

public enum EProductType
{
    Eletronics = 1,
    Helath = 2,
    Beauty = 3,
    Fashion = 4,
}

public class Discount
{
    public decimal Calculate(EProductType productType, decimal price)
    {
        if (productType == EProductType.Eletronics)
            return price * 0.2m;
        
        if (productType == EProductType.Helath)
            return price * 0.3m;
        
        if (productType == EProductType.Beauty)
            return price * 0.4m;
        
        if (productType == EProductType.Fashion)
            return price * 0.5m;

        return price;
    }
}
    
 