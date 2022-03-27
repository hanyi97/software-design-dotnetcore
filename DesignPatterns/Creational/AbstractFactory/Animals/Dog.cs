namespace DesignPatterns.Creational.AbstractFactory.Animals;

public class Dog : IAnimal
{
    public string Speak()
    {
        return "Woof";
    }
}