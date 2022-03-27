namespace DesignPatterns.Creational.Factory;

public class MoneyBack : ICreditCard
{
    public string GetCardType()
    {
        return "Money Back";
    }

    public int GetCreditLimit()
    {
        return 15000;
    }

    public int GetAnnualCharge()
    {
        return 500;
    }
}