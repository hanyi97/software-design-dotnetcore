namespace DesignPatterns.Behavioural.Template;

public class TemplateClient : ClientTemplate
{
    public override string Pattern => "Template";

    public override void RunClient()
    {
        Console.WriteLine("Building a concrete house\n");
        HouseTemplate houseTemplate = new ConcreteHouse();
        houseTemplate.BuildHouse();
        
        Console.WriteLine();
        
        Console.WriteLine("Building a wooden house\n");
        houseTemplate = new WoodenHouse();
        houseTemplate.BuildHouse();
    }
}