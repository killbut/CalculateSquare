namespace CalculateSquare;

public class Trapeze : IFigure
{
    private readonly int[] _sides;
    private readonly int _h;
    
    public int[] Sides => _sides;
    public int H => _h;

    private int CalculateH()
    {
        var a = Sides[0];
        var b = Sides[1];
        var c = Sides[2];
        var d = Sides[3];
        return (int) Math.Sqrt(c * c - 1 / 4 * Math.Pow( ((c * c - d * d) / (b - a) + (b - a)),2));
        
    }
    
    public Trapeze(int a, int b, int c, int d)
    {
        if (a <= 0 || b <= 0 || c <= 0 || d<=0)
            throw new ArgumentException("Sides is negative");
        if (Math.Abs(a - b) > c + d || c > Math.Abs(a - b) + d || d > Math.Abs(a - b) + c)
            throw new ArgumentException("Trapeze is degenerate");
        _sides = new int[] { a, b, c, d };
        _h = CalculateH();
    }
    
    public Trapeze(int a, int b, int h)
    {
        if (a <= 0 || b <= 0 || h <= 0)
            throw new ArgumentException("Sides is negative");
        _sides = new int[] { a, b };
        _h = h;
    }
    public double CalculateSquare()
    {
        var a = Sides[0];
        var b = Sides[1];
        return (a + b) / 2 * H;
    }
}