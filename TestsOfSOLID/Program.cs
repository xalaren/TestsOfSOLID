using OpenClosedPrinciple;
using SelectableUserInterface;
using SingleResponsibilityPrinciple;
using SingleResponsibilityPrinciple.Reports;
using SingleResponsibilityPrinciple.TextGen;
using TestsOfSOLID;

var optionSelector = new OptionSelector
(
    new List<Option>()
    {
        new Option() { Title = "SRP", Action = SingleResponsibilityPrincipleExampleRun },
        new Option() { Title = "OCP", Action = OpenClosedPrincipleExampleRun }
    }
);

var consoleSelectableUI = new ConsoleSelectableUI(optionSelector, "Choose SOLID principle example: ");
consoleSelectableUI.Run();

void SingleResponsibilityPrincipleExampleRun()
{
    ITextGenerator randomTextGenerator = new RandomTextGenerator();
    ReportGenerator reportGenerator = new ReportGenerator(randomTextGenerator);
    ISaver<Report> reportSaver = new ReportSaver();
    IStorage<Report> reportStorage = new ReportStorage();
    Report report1000 = reportGenerator.Generate(1000);
    reportSaver.Save(report1000, reportStorage);
    Report report10000 = reportGenerator.Generate(10000);
    reportSaver.Save(report10000, reportStorage);
    for (int i = 0; i < reportStorage.Items.Count; i++)
    {
        Console.WriteLine($"Report #{i + 1}:\n{reportStorage.Items[i].Content}\n");
    }
}

void OpenClosedPrincipleExampleRun()
{
    List<Shape> shapes =
    [
        new Rectangle() { Length = 10, Width = 20 },
        new Square() { SideLength = 20 },
        new Circle(15),
        new Triangle() { FirstSideLength = 5, SecondSideLength = 6, ThirdSideLength = 10 }
    ];

    Console.WriteLine($"Shapes area:\n");
    foreach (var shape in shapes)
    {
        Console.WriteLine($"{shape.GetType().Name} area is: {shape.CalculateArea()}");
    }
}