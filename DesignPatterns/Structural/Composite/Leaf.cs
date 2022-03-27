namespace DesignPatterns.Structural.Composite;

public class Leaf : IComponent
{
    public int Price { get; set; }
    public string Name { get; set; }
    
    public Leaf(string name, int price)
    {
        Name = name;
        Price = price;
    }
    
    public void DisplayPrice()
    {
        Console.WriteLine($"{Name} costs {Price}");
    }
}