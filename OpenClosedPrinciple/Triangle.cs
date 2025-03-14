namespace OpenClosedPrinciple;

public class Triangle : Shape
{
    private double firstSideLength;
    private double secondSideLength;
    private double thirdSideLength;

    public double FirstSideLength
    {
        get => firstSideLength;
        set
        {
            if (value < 0) return;
            firstSideLength = value;
        }
    }
    
    public double SecondSideLength
    {
        get => secondSideLength;
        set
        {
            if (value < 0) return;
            secondSideLength = value;
        }
    }
    
    public double ThirdSideLength
    {
        get => thirdSideLength;
        set
        {
            if (value < 0) return;
            thirdSideLength = value;
        }
    }
    
    public override double CalculateArea()
    {
        if (!IsTriangleExists()) return 0;
        
        var halfPerimeter = CalculatePerimeter() / 2.0;
        return Math.Round
        (
            Math.Sqrt(halfPerimeter * (halfPerimeter - firstSideLength) * (halfPerimeter - secondSideLength) *
                         (halfPerimeter - thirdSideLength)), 2
        );
    }

    private double CalculatePerimeter()
    {
        return firstSideLength + secondSideLength + thirdSideLength;
    }

    private bool IsTriangleExists()
    {
        return
            firstSideLength + secondSideLength >= thirdSideLength &&
            secondSideLength + thirdSideLength >= firstSideLength &&
            firstSideLength + thirdSideLength >= secondSideLength;
    }
}