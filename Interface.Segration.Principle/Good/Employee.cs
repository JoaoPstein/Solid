namespace Interface.Segration.Principle.Good;

public interface ISalarayCalculator
{
    void CalculateSalary();
}

public interface IBenefitsCalculateor
{
    void CalculateBenefits();
}

public class FullTimeEmployee : ISalarayCalculator, IBenefitsCalculateor
{
    public void CalculateSalary()
    {
        throw new NotImplementedException();
    }

    public void CalculateBenefits()
    {
        throw new NotImplementedException();
    }
}

public class ContractEmployee : ISalarayCalculator
{
    public void CalculateSalary()
    {
        throw new NotImplementedException();
    }
}