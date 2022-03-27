namespace SOLID.LSP.Improved;

/// <summary>
/// Better design. Now it follows LSP.
///
/// Now we can replace the Car class with either BMW or Audi class
/// and it will behave the same way, getting the colour of the appropriate
/// car.
/// </summary>
internal abstract class Car
{
    public abstract string GetColour();
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