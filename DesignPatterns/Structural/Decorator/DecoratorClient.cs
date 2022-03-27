namespace DesignPatterns.Structural.Decorator;

public class DecoratorClient : ClientTemplate
{
    public override string Pattern => "Decorator";

    public override void RunClient()
    {
        ICar bmwCar1 = new BMWCar();
        bmwCar1.ManufactureCar();
        Console.WriteLine(bmwCar1);
        Console.WriteLine();

        DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
        carWithDieselEngine.ManufactureCar();
        
        Console.WriteLine();
        
        ICar bmwCar2 = new BMWCar();
        PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
        carWithPetrolEngine.ManufactureCar();

        Console.WriteLine();
        
        ConvertableCarDecorator convertableCar = new ConvertableCarDecorator(bmwCar2);
        convertableCar.ManufactureCar();
    }
}