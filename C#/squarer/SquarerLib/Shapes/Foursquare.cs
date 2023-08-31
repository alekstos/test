namespace SquarerLib.Shapes;

public class Foursquare : Shape
{
    private double _a;
    private double _b;

    public override double Square { get { return _a * _b; }}

    public Foursquare(double a, double b)
    {
        ValidateParameter(a,b);
        _a = a;
        _b = b;
    }
}

