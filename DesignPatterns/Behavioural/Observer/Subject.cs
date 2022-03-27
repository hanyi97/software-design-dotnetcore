namespace DesignPatterns.Behavioural.Observer;

/// <summary>
/// Store the states of interest to the observers and also
/// responsible for sending the notification to its observers when its
/// state changes.
/// </summary>
public class Subject : ISubject
{
    private List<IObserver> _observers = new();
    private string ProductName { get; set; }
    private int ProductPrice { get; set; }
    private string Availability { get; set; }
    
    public Subject(string productName, int productPrice, string availability)
    {
        ProductName = productName;
        ProductPrice = productPrice;
        Availability = availability;
    }
    
    public string GetAvailability()
    {
        return Availability;
    }
    
    public void SetAvailability(string availability)
    {
        Availability = availability;
        Console.WriteLine("Availability changed from Out of Stock to Available.");
        NotifyObservers();
    }
    
    public void RegisterObserver(IObserver observer)
    {
        Console.WriteLine($"Observer Added: {((Observer)observer).UserName}");
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        Console.WriteLine($"Product Name: {ProductName}, " +
                          $"Product Price: {ProductPrice} is now available. So notifying all Registered users");
    }
}