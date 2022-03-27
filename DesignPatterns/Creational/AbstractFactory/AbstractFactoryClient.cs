using DesignPatterns.Creational.AbstractFactory.Animals;

namespace DesignPatterns.Creational.AbstractFactory;

public class AbstractFactoryClient : ClientTemplate
{
    public override string Pattern => "Abstract Factory";

    public override void RunClient()
    {
        IAnimal animal;
        AnimalFactory animalFactory;

        animalFactory = AnimalFactory.CreateAnimalFactory("Land");
        animal = animalFactory.GetAnimal("Dog");
        Console.WriteLine($"Factory Type: {animalFactory.GetType().Name}");
        Console.WriteLine($"Animal Type: {animal.GetType().Name}");
        Console.WriteLine(animal.Speak());
    }
}