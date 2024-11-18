namespace Interface.Segration.Principle.Bad;

public interface IEmployee
{
    string Name { get; set; }
    void CalculateSalary();
    void CalculateBenefits();
}

public class FullTimeEmployee : IEmployee
{
    public string Name { get; set; }
    
    public void CalculateSalary()
    {
        throw new NotImplementedException();
    }

    public void CalculateBenefits()
    {
        throw new NotImplementedException();
    }
}

public class ContractEmployee : IEmployee
{
    public string Name { get; set; }
    
    public void CalculateSalary()
    {
        throw new NotImplementedException();
    }

    public void CalculateBenefits()
    {
        throw new NotImplementedException();
    }
}