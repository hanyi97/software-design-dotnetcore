using DesignPatterns.Creational.AbstractFactory.Animals;

namespace DesignPatterns.Creational.AbstractFactory;

public class LandAnimalFactory : AnimalFactory
{
    public override IAnimal GetAnimal(string animalType)
    {
        return animalType switch
        {
            "Dog" => new Dog(),
            "Cat" => new Cat(),
            "Lion" => new Lion(),
            _ => null!
        };
    }
}