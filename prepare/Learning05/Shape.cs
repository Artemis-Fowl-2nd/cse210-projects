public abstract class Shape
{
    protected string _color;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string a)
    {
        _color = a;
    }
    public Shape(string a)
    {
        _color = a;
    }

    public abstract double GetArea();
    
}