namespace CalculateSquare;

public class Circle : IFigure
{
    private readonly double _radius;
    public double Radius => _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new Exception("Radius is <= 0");
        _radius = radius;
    }

    public double CalculateSquare()
    {
        return MathF.PI * _radius * _radius;
    }
}