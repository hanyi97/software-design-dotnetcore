namespace DesignPatterns.Structural.Decorator;

/// <summary>
/// This class will add diesel engine to the car.
/// </summary>
public class DieselCarDecorator : CarDecorator
{
    public DieselCarDecorator(ICar car) : base(car)
    {
    }

    public override ICar ManufactureCar()
    {
        car.ManufactureCar();
        AddEngine(car);
        return car;
    }

    public void AddEngine(ICar car)
    {
        if (car is not BMWCar) return;
        
        var bmwCar = car as BMWCar;
        bmwCar.Engine = "Diesel Engine";
        Console.WriteLine($"DieselCarDecorator added Diesel Engine to the Car: {car}");
    }
}