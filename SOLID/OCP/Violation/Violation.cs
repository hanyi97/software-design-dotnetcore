namespace SOLID.OCP.Violation;

/// <summary>
/// This follows SRP but violates OCP.
///
/// AreaCalculator class is not closed
/// for modification. We need to add extra
/// conditions in the future if we want to
/// add more shapes in the future. 
/// </summary>
internal class AreaCalculator
{
    public double TotalArea(object[] arrObjects)
    {
        double area = 0;
        Rectangle rect;
        Circle circle;
        foreach (var obj in arrObjects)
        {
            if (obj is Rectangle)
            {
                rect = (Rectangle)obj;
                area += rect.Height * rect.Width;
            }
            else
            {
                circle = (Circle)obj;
                area += circle.Radius * circle.Radius * Math.PI;
            }
        }
        return area;
    }
}

internal class Rectangle
{
    public double Height { get; set; }
    public double Width { get; set; }
}

internal class Circle
{
    public double Radius { get; set; }
}