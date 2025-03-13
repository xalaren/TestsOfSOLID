namespace SingleResponsibilityPrinciple.Reports;

public class ReportSaver : ISaver<Report>
{
    public void Save(Report item, IStorage<Report> storage)
    {
        storage.Items.Add(item);
    }
}