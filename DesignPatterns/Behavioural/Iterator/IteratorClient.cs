namespace DesignPatterns.Behavioural.Iterator;

public class IteratorClient : ClientTemplate
{
    public override string Pattern => "Iterator";

    public override void RunClient()
    {
        var collection = new ConcreteCollection();
        
        collection.AddEmployee(new Employee("Anurag", 100));
        collection.AddEmployee(new Employee("Pranaya", 101));
        collection.AddEmployee(new Employee("Santosh", 102));
        collection.AddEmployee(new Employee("Priyanka", 103));
        collection.AddEmployee(new Employee("Abinash", 104));
        collection.AddEmployee(new Employee("Preety", 105));

        var iterator = collection.CreateIterator();
        
        Console.WriteLine("Iteratin over collection:");

        for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}");
        }
    }
}