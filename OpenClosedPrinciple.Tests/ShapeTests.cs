namespace OpenClosedPrinciple.Tests;

public class ShapeTests
{
    [TestCaseSource(typeof(ShapeData), nameof(ShapeData.CalculateAreaTestCases))]
    public void IsActualAreaIsEqualToExpected_CalculateAreaTest(Shape shape, double expectedArea)
    {
        double actualArea = shape.CalculateArea();
        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }
}

class ShapeData
{
    public static IEnumerable<object> CalculateAreaTestCases()
    {
        yield return new object[] { new Circle(10), 314.16 };
        yield return new object[] { new Circle(0), 0 };
        yield return new object[] { new Circle(-1), 0 };
        
        yield return new object[] { new Square() { SideLength = 10}, 100 };
        yield return new object[] { new Square() { SideLength = 3}, 9 };
        yield return new object[] { new Square() { SideLength = 17}, 289 };
        yield return new object[] { new Square() { SideLength = 0}, 0 };
        yield return new object[] { new Square() { SideLength = -1}, 0 };
        
        yield return new object[] { new Rectangle() { Width = 10, Length = 10 }, 100 };
        yield return new object[] { new Rectangle() { Width = 3, Length = 3 }, 9 };
        yield return new object[] { new Rectangle() { Width = 17, Length = 20 }, 340 };
        yield return new object[] { new Rectangle() { Width = 0, Length = 0 }, 0 };
        yield return new object[] { new Rectangle() { Width = -1, Length = 0 }, 0 };
        yield return new object[] { new Rectangle() { Width = -1, Length = -1 }, 0 };

        yield return new object[]
        {
            new Triangle()
            {
                FirstSideLength = 0,
                SecondSideLength = 0,
                ThirdSideLength = 0
            },
            0
        };
        yield return new object[]
        {
            new Triangle()
            {
                FirstSideLength = -1,
                SecondSideLength = -1,
                ThirdSideLength = -1
            },
            0
        };
        yield return new object[]
        {
            new Triangle()
            {
                FirstSideLength = 2,
                SecondSideLength = 3,
                ThirdSideLength = -1
            },
            0
        };
        yield return new object[]
        {
            new Triangle()
            {
                FirstSideLength = -2,
                SecondSideLength = 3,
                ThirdSideLength = 1
            },
            0
        };
        yield return new object[]
        {
            new Triangle()
            {
                FirstSideLength = 2,
                SecondSideLength = -3,
                ThirdSideLength = 1
            },
            0
        };
        yield return new object[]
        {
            new Triangle()
            {
                FirstSideLength = 10,
                SecondSideLength = 10,
                ThirdSideLength = 10
            },
            43.3
        };
        yield return new object[]
        {
            new Triangle()
            {
                FirstSideLength = 5,
                SecondSideLength = 12,
                ThirdSideLength = 11
            },
            27.5
        };
    }
}