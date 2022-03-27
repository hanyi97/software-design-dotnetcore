using DesignPatterns.Creational.AbstractFactory.Animals;

namespace DesignPatterns.Creational.AbstractFactory;

public class SeaAnimalFactory : AnimalFactory
{
    public override IAnimal GetAnimal(string animalType)
    {
        return animalType switch
        {
            "Shark" => new Shark(),
            "Octopus" => new Octopus(),
            _ => null!
        };
    }
}