namespace Mindbox;

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius) 
    {
        Radius = radius;
    }

    public double GetArea() =>
        Math.PI * Radius * Radius;
}
