namespace DesignPatterns.Creational.Factory;

public class Titanium : ICreditCard
{
    public string GetCardType()
    {
        return "Titanium";
    }

    public int GetCreditLimit()
    {
        return 25000;
    }

    public int GetAnnualCharge()
    {
        return 1500;
    }
}