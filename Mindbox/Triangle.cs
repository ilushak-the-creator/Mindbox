namespace Mindbox;

public class Triangle : IShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Sides must be positive.");
        }

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("The given sides do not form a triangle.");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double GetArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s- SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightAngled()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }
}
