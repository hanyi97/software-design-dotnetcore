using DesignPatterns.Creational.AbstractFactory.Animals;

namespace DesignPatterns.Creational.AbstractFactory;

/// <summary>
/// Abstract Factory: defines an interface for creating families of related or dependent
/// objects without specifying their concrete classes.
///
/// AnimalFactory declares an interface for operations that create abstract products.
/// The GetAnimal method is an abstract method that is going to be implemented by
/// the child factory classes.
///
/// The CreateAnimalFactory method returns the appropriate factory depending on the
/// factory type.
/// </summary>
public abstract class AnimalFactory
{
    public abstract IAnimal GetAnimal(string animalType);

    public static AnimalFactory CreateAnimalFactory(string factoryType)
    {
        if (factoryType.Equals("Sea"))
            return new SeaAnimalFactory();
        else
            return new LandAnimalFactory();
    }
}