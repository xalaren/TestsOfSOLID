namespace OpenClosedPrinciple;

public class Square : Shape
{
    private double sideLength;

    public double SideLength
    {
        get => sideLength;
        set
        {
            if (value < 0) return;
            sideLength = value;
        }
    }
    
    public override double CalculateArea()
    {
        return Math.Pow(sideLength, 2);
    }
}