namespace SquarerLib.Shapes;

public class Triangle : Shape
{
    double _a;
    double _b;
    double _c;

    double p { get { return (_a + _b + _c) / 2; } }

    double h { get { return 2 / _a * Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)); } }

    public bool isRightTriangle
    {
        get
        {
            return (Math.Pow(_a, 2) + Math.Pow(_b, 2) == Math.Pow(_c, 2)) ||
                (Math.Pow(_a, 2) + Math.Pow(_c, 2) == Math.Pow(_b, 2)) ||
                (Math.Pow(_c, 2) + Math.Pow(_b, 2) == Math.Pow(_a, 2));
        }
    }

    public override double Square { get { return 0.5 * _a * h; } }

    public Triangle(double a, double b, double c)
    {
        ValidateParameter(a, b, c);
        _a = a;
        _b = b;
        _c = c;
    }

    internal override void ValidateParameter(params double[] payload)  
    {
        var a = payload[0];
        var b = payload[1];
        var c = payload[2];

        base.ValidateParameter();

        if (a + b <= c || a + c <= b || b + c <= a) throw new SquarerException("This triangle can't exists.");
    }
}
