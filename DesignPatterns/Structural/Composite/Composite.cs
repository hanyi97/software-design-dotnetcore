namespace DesignPatterns.Structural.Composite;

/// <summary>
/// Composite: Compose objects into tree structures to represent part-whole hierarchies.
/// Composite lets clients treat individual objects and compositions of objects uniformly.
/// </summary>
public class Composite : IComponent
{
    public string Name { get; set; }
    private List<IComponent> components = new();
    
    public Composite(string name)
    {
        Name = name;
    }

    public void AddComponent(IComponent component)
    {
        components.Add(component);
    }
    
    public void DisplayPrice()
    {
        Console.WriteLine(Name);
        foreach (var item in components)
        {
            item.DisplayPrice();
        }
    }
}