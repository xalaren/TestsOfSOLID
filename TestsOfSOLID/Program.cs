using SingleResponsibilityPrinciple;
using SingleResponsibilityPrinciple.Reports;
using SingleResponsibilityPrinciple.TextGen;

SingleResponsibilityPrincipleExampleRun();

static void SingleResponsibilityPrincipleExampleRun()
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