namespace DesignPatterns.Creational.AbstractFactory.Animals;

public class Cat : IAnimal
{
    public string Speak()
    {
        return "Meow";
    }
}