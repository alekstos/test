namespace SquarerLib.Shapes;

public class Circle : Shape
{
    double _r;

    public override double Square { get { return _r * _r * pi; } }

    public Circle(double r)
    {
        ValidateParameter(r);
        _r = r;
    }
}
