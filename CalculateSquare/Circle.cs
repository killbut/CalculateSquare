namespace CalculateSquare;

public class Circle : IFigure
{
    private readonly double _radius;
    public double Radius => _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius is <= 0");
        _radius = radius;
    }

    public double CalculateSquare()
    {
        return Math.Round(MathF.PI * _radius * _radius, 2);
    }
}