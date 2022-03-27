namespace DesignPatterns.Structural.Decorator;

/// <summary>
/// Decorator: Dynamically change the functionality of an object at runtime without impacting
/// the existing functionality of the object.
///
/// This is going to be an abstract class and it also implements the ICar interface.
///
/// The ManufactureCar() method is set to virtual so that it can be overridden by the child classes.
/// </summary>
public abstract class CarDecorator : ICar
{
    protected ICar car;

    public CarDecorator(ICar car)
    {
        this.car = car;
    }
    
    public virtual ICar ManufactureCar()
    {
        return car.ManufactureCar();
    }
}