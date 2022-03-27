namespace DesignPatterns.Structural.Decorator;

public class ConvertableCarDecorator : CarDecorator
{
    public ConvertableCarDecorator(ICar car) : base(car)
    {
    }

    public override ICar ManufactureCar()
    {
        car.ManufactureCar();
        AddConvertable(car);
        return car;
    }

    public void AddConvertable(ICar car)
    {
        if (car is not BMWCar) return;
        
        var bmwCar = car as BMWCar;
        bmwCar.Type = "Convertable";
        Console.WriteLine($"ConvertableCarDecorator added Convertable type to the Car: {car}");
    }
}