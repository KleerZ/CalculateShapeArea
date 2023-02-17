using CalculateShapeArea.Interfaces;

namespace CalculateShapeArea;

public class Triangle : ITriangle
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    private const double Precision = 1e-12;

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double CalculateArea()
    {
        if (IsTriangle() == false)
            throw new ArgumentException("Triangle with these sides does not exist");
        
        var p = (A + B + C) / 2;

        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { A, B, C };
        var hypotenuse = sides.Max();
        var legs = sides.Where(s => s < hypotenuse)
            .Sum(s => Math.Pow(s, 2));

        return Math.Abs(legs - Math.Pow(hypotenuse, 2)) < Precision;
    }

    private bool IsTriangle() =>
        A + B > C && B + C > A && C + A > B;
}