public class Square : Shape
{
    private int _side;
    public Square(string a, int b):base(a)
    {
        _side = b;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}