using System.Text;

namespace SingleResponsibilityPrinciple.Reports;

public class Report
{
    public Report() { }
    public Report(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            Content = string.Empty;
            return;
        }
        
        Content = content;
    }
    public required string Content { get; init; }
}