namespace OpenClosedPrinciple;

public class Rectangle : Shape
{
    private double width;
    private double length;

    public double Width
    {
        get => width;
        set
        {
            if (value < 0) return;
            width = value;
        }
    }
    
    public double Length
    {
        get => length;
        set
        {
            if (value < 0) return;
            length = value;
        }
    }
    
    public override double CalculateArea()
    {
        return length * width;
    }
}