using System.Drawing;
using System.Numerics;

namespace OpenClosedPrinciple;

public class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get => radius;
        set
        {
            if (value < 0) return;
            radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
    }
}