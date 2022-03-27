namespace DesignPatterns.Creational.Factory;

/// <summary>
/// Factory: is an object which is used for creating other objects.
///
/// The factory is usually static.
/// It will return the object based on the type of object that is requested.
/// </summary>
public static class CreditCardFactory
{
    public static ICreditCard GetCreditCard(string cardType)
    {
        return cardType switch
        {
            "MoneyBack" => new MoneyBack(),
            "Titanium" => new Titanium(),
            "Platinum" => new Platinum(),
            _ => new MoneyBack()
        };
    }
}