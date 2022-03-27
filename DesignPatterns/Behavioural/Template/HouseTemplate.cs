namespace DesignPatterns.Behavioural.Template;

/// <summary>
/// Template: Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
///
/// This abstract class defines a set of abstract methods that need to be implemented by subclasses.
/// </summary>
public abstract class HouseTemplate
{
    public void BuildHouse()
    {
        BuildFoundation();
        BuildPillars();
        BuildWalls();
        BuildWindows();
        Console.WriteLine("House is built");
    }

    protected abstract void BuildFoundation();
    protected abstract void BuildPillars();
    protected abstract void BuildWalls();
    protected abstract void BuildWindows();
}