
namespace TestProject1;

public class TestTriangle
{
    [Fact]
    public void IsSquareCorrect()
    {
        Assert.Equal(6, new Triangle(3,4,5).CalculateSquare());
    }

    [Fact]
    public void IsSquareIncorrect()
    {
        Assert.NotEqual(10,new Triangle(3,4,5).CalculateSquare());
    }

    [Fact]
    public void IsTriangleDegenerate()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, -1, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(100, 1, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }
    [Fact]
    public void IsTriangleNotDegenerate()
    {
        var exception = Record.Exception(() => new Triangle(2, 2, 3));
        Assert.Null(exception);
    }

    [Fact]
    public void IsRectangularTriangle()
    {
        Assert.True(new Triangle(3,4,5).IsRectangular());
    }
    [Fact]
    public void IsNotRectangularTriangle()
    {
        Assert.False(new Triangle(2,2,5).IsRectangular());
    }
}