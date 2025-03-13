using System.Text;

namespace SingleResponsibilityPrinciple.Reports;

public class Report
{
    private readonly string content = string.Empty;
    public string Content
    {
        get => content;
        init
        {
            if (string.IsNullOrWhiteSpace(value)) return;

            content = value;
        }
    }
}