using SingleResponsibilityPrinciple.Reports;
using SingleResponsibilityPrinciple.TextGen;

namespace SingleResponsibilityPrinciple;

public class ReportGenerator(ITextGenerator textGenerator)
{
    public Report Generate(int reportLength)
    {
        return new Report()
        {
            Content = textGenerator.Generate(reportLength)
        };
    }
}