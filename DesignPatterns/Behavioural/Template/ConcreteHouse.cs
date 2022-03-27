namespace DesignPatterns.Behavioural.Template;

public class ConcreteHouse : HouseTemplate
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building foundation with cement,iron rods and sand");
    }

    protected override void BuildPillars()
    {
        Console.WriteLine("Building concrete pillars with cement and sand");
    }

    protected override void BuildWalls()
    {
        Console.WriteLine("Building concrete walls");
    }

    protected override void BuildWindows()
    {
        Console.WriteLine("Building concrete windows");
    }
}