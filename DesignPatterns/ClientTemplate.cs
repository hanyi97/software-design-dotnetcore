namespace DesignPatterns;

public abstract class ClientTemplate
{
    public abstract string Pattern { get; }
    
    public void Run()
    {
        PrintHeading();
        RunClient();
        PrintFooter();
        Console.WriteLine();
    }
    
    public abstract void RunClient();
    
    public void PrintHeading()
    {
        Console.WriteLine("*************************");
        Console.WriteLine($"{Pattern} Pattern");
        Console.WriteLine("*************************");
    }
    
    public void PrintFooter()
    {
        Console.WriteLine("*************************");
        Console.WriteLine($"End of {Pattern} Pattern");
        Console.WriteLine("*************************");
    }
}