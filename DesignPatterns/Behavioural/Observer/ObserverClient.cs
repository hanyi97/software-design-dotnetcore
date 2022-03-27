namespace DesignPatterns.Behavioural.Observer;

public class ObserverClient : ClientTemplate
{
    public override string Pattern => "Observer";

    public override void RunClient()
    {
        // Create a product with OOS status
        var redmi = new Subject("Red MI Mobile", 10000, "Out of Stock");

        var user1 = new Observer("Anurag", redmi);
        var user2 = new Observer("Vikas", redmi);
        var user3 = new Observer("Priyanka", redmi);
        
        Console.WriteLine($"Red MI Mobile current state: {redmi.GetAvailability()}");
        Console.WriteLine();
        
        redmi.SetAvailability("Available");
    }
}