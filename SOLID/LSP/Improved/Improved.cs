namespace SOLID.LSP.Improved;

/// <summary>
/// Better design. Now it follows LSP.
///
/// Now we can replace the Car class with either BMW or Audi class
/// and it will behave the same way, getting the colour of the appropriate
/// car.
/// </summary>

internal abstract class Vehicle
{
    public abstract string GetColour();
}

internal abstract class Car : Vehicle
{
}

internal abstract class Motorcycle : Vehicle
{
}

internal class BMW : Car
{
    public override string GetColour()
    {
        return "Blue";
    }
}

internal class Audi : Car
{
    public override string GetColour()
    {
        return "Black";
    }
}
