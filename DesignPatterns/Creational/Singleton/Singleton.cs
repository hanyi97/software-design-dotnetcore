namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// Singleton: A class which has only one instance and provides global access to it.
///
/// 1. Declare a private and parameterless constructor.
/// 2. The class should be sealed which will prevent the class from being inherited.
/// 3. Create a private static variable that is going to hold a reference to the single instance of the class.
/// 4. Create a public static property/method which will return the single instance of the class.
/// </summary>
public sealed class Singleton
{
    private static int counter;
    private static Singleton instance;

    public static Singleton GetInstance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }

    private Singleton()
    {
        counter++;
        Console.WriteLine($"Counter Value: {counter}");
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}