namespace TestProject1;

public class TestCircle
{
    [Fact]
    public void IsSquareCorrect()
    {
        Assert.Equal(Math.Round(Math.PI*4*4,2),new Circle(4).CalculateSquare());
    }

    [Fact]
    public void IsSquareIncorrect()
    {
        Assert.NotEqual(Math.Round(Math.PI*5*5),new Circle(2).CalculateSquare());
    }
    [Fact]
    public void IsRadiusCorrect()
    {
        Assert.Equal(4,new Circle(4).Radius);
    }
    [Fact]
    public void IsRadiusIncorrect()
    {
        Assert.Throws<ArgumentException>(()=>new Circle(-1));
    }
}