namespace DesignPatterns.Structural.Decorator;

/// <summary>
/// This class will add petrol to the car.
/// </summary>
public class PetrolCarDecorator : CarDecorator
{
    public PetrolCarDecorator(ICar car) : base(car)
    {
    }

    public override ICar ManufactureCar()
    {
        car.ManufactureCar();
        AddEngine(car);
        return car;
    }

    private void AddEngine(ICar car)
    {
        if (car is not BMWCar) return;
        
        var bmwCar = car as BMWCar;
        bmwCar.Engine = "Petrol";
        Console.WriteLine($"PetrolCarDecorator added Petrol Engine to the Car: {car}");
    }
}