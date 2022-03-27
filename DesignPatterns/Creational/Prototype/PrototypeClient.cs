namespace DesignPatterns.Creational.Prototype;

public class PrototypeClient : ClientTemplate
{
    public override string Pattern => "Prototype";

    public override void RunClient()
    {
        Console.WriteLine("Without cloning");
        var e1 = new Employee();
        e1.Name = "Jane";
        e1.Department = "Sales";

        var e2 = e1;
        e2.Name = "June";

        Console.WriteLine("Employee 1");
        Console.WriteLine($"Name: {e1.Name}, Department: {e1.Department}");

        Console.WriteLine("Employee 2");
        Console.WriteLine($"Name: {e2.Name}, Department: {e2.Department}");

        Console.WriteLine();

        Console.WriteLine("With cloning");

        var emp1 = new Employee();
        emp1.Name = "John Cena";
        emp1.Department = "IT";

        var emp2 = emp1.Clone();
        emp2.Name = "Spongebob";

        Console.WriteLine("Employee 1");
        Console.WriteLine($"Name: {emp1.Name}, Department: {emp1.Department}");

        Console.WriteLine("Employee 2");
        Console.WriteLine($"Name: {emp2.Name}, Department: {emp2.Department}");
    }
}