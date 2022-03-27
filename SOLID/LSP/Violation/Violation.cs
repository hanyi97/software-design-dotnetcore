namespace SOLID.LSP.Violation;

/// <summary>
/// This violates LSP.
///
/// Car car = new Motorcycle();
/// Will return the color of Blue, but not red.
/// This means that once the child object is replaced, the
/// behaviour is also changed.
/// </summary>
internal class Car
{
    public virtual string GetColour()
    {
        return "Red";
    }
}

internal class MotorCycle : Car
{
    public override string GetColour()
    {
        return "Blue";
    }
}

