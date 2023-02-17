using Xunit;

namespace CalculateShapeArea.Tests;

public class TriangleTest
{
    private Triangle Triangle { get; set; }
    
    [Theory]
    [InlineData(10, 5, 7, 16.248077)]
    [InlineData(5.2, 7.6, 4.3, 10.753794)]
    public void CalculateAreaTest(double a, double b, double c, double expected)
    {
        Triangle = new Triangle(a, b, c);
        Assert.Equal(expected, Triangle.CalculateArea(), 5);
    }
    
    [Theory]
    [InlineData(12, 5, 7)]
    [InlineData(11.5, 4.2, 6)]
    public void IsTriangleTest(double a, double b, double c)
    {
        Triangle = new Triangle(a, b, c);
        Assert.Throws<ArgumentException>(() => Triangle.CalculateArea());
    }

    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(4.5, 6, 7.5)]
    public void IsRightTriangleTest(double a, double b, double c)
    {
        Triangle = new Triangle(a, b, c);
        Assert.True(Triangle.IsRightTriangle());
    }

    [Theory]
    [InlineData(11, 4, 6.6)]
    [InlineData(3.8, 7, 5.4)]
    public void IsNotRightTriangleTest(double a, double b, double c)
    {
        Triangle = new Triangle(a, b, c);
        Assert.False(Triangle.IsRightTriangle());
    }
}