namespace CalculateSquare;

public class Triangle : IFigure
{
    private readonly int[] _sides;
    public int[] Sides => _sides;
    
    public Triangle(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Sides is negative");
        if (a + b == c || a + c == b || b + c == a)
            throw new ArgumentException("Triangle is degenerate");
        _sides = new int[] { a, b, c };
    }

    public int CalculatePerimeter()
    {
        return Sides.Sum();
    }
    public double CalculateSquare()
    {
        var p=CalculatePerimeter() /2;
        return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) *
                         (p - Sides[2])); // Heron's formula
    }
    
    public bool IsRectangular()
    {
        var a = Sides[0];
        var b = Sides[1];
        var c = Sides[2];
        return ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a));
    }
}