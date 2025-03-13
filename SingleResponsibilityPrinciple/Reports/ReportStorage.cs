using SingleResponsibilityPrinciple.Reports;

namespace SingleResponsibilityPrinciple;

public class ReportStorage : IStorage<Report>
{
    public IList<Report> Items { get; } = new List<Report>();
}