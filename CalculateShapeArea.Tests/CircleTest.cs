using CalculateShapeArea.Interfaces;
using Xunit;

namespace CalculateShapeArea.Tests;

public class CircleTest
{
    private IShape Circle { get; set; }
    
    [Theory]
    [InlineData(25, 1963.495408)]
    [InlineData(7, 153.93804)]
    public void CalculateAreaTest(double radius, double expected)
    {
        Circle = new Circle(radius);
        Assert.Equal(expected, Circle.CalculateArea(), 5);
    }
}