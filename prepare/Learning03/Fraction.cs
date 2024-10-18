public class Fraction{
    private int _top;
    private int _bottom;

     public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int input)
    {
        _top = input;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return($"{_top}/{_bottom}");
    }

    public int GetBottom()
    {
        return _bottom;
    }
    
    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int input)
    {
        _bottom = input;
    }

    public void SetTop(int input)
    {
        _top = input;
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
        
    }
}