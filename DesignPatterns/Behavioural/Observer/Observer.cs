namespace DesignPatterns.Behavioural.Observer;

/// <summary>
/// Observer: Defines an updating interface for objects that should be notified of changes in a subject.
/// </summary>
public class Observer : IObserver
{
    public string UserName { get; set; }

    public Observer(string username, ISubject subject)
    {
        UserName = username;
        subject.RegisterObserver(this);
    }
    
    public void Update(string availability)
    {
        Console.WriteLine($"Hello {UserName}, Product is now {availability} on Amazon");
    }
}