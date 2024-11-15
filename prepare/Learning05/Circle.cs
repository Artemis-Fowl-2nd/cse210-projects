public class Circle : Shape
{
    private int _radius;
    

    public Circle(string color, int a):base(color)
    {
        _radius = a;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}