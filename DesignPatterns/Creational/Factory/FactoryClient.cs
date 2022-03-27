namespace DesignPatterns.Creational.Factory;

public class FactoryClient : ClientTemplate
{
    public override string Pattern => "Factory";

    public override void RunClient()
    {
        var card = CreditCardFactory.GetCreditCard("Platinum");
        Console.WriteLine(card.GetCardType());
    }
}