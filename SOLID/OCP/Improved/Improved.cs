namespace SOLID.OCP.Improved;

/// <summary>
/// Better design. Now it follows SRP and OCP.
///
/// Whenever you introduce a new shape by deriving from the
/// Shape abstract class, you need not change the AreaCalculator class.
/// </summary>
internal class AreaCalculator
{
    public double TotalArea(Shape[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.Area();
        }

        return area;
    }
    
}

internal abstract class Shape
{
    public abstract double Area();
}

internal class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }

    public override double Area()
    {
        return Height * Width;
    }
}

internal class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Radius * Radius * Math.PI;
    }
}