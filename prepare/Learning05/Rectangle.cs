public class Rectangle : Shape
{
    private int _side1;
    private int _side2;

    public Rectangle(string color, int a, int b):base(color)
    {
        _side1 = a;
        _side2 = b;
    }

    public override double GetArea()
    {
        return _side1 * _side2;
    }
}