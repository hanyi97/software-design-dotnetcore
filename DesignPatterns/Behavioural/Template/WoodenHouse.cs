namespace DesignPatterns.Behavioural.Template;

public class WoodenHouse : HouseTemplate
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building wooden foundation");
    }

    protected override void BuildPillars()
    {
        Console.WriteLine("Building wooden pillars");
    }

    protected override void BuildWalls()
    {
        Console.WriteLine("Building wooden walls");
    }

    protected override void BuildWindows()
    {
        Console.WriteLine("Building wooden windows");
    }
}