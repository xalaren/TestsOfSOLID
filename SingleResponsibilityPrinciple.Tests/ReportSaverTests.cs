using Moq;
using SingleResponsibilityPrinciple.Reports;

namespace SingleResponsibilityPrinciple.Tests;

public class ReportSaverTests
{
    [TestCaseSource(typeof(ReportsData), nameof(ReportsData.ManyReportsTestCases))]
    public void ManyReports_SaveTest(IList<Report> expectedReportsList)
    {
        Report report = new Report();
        Mock<IStorage<Report>> reportStorageMock = new Mock<IStorage<Report>>();

        reportStorageMock.Setup(storage => storage.Items).Returns(expectedReportsList);

        ReportSaver reportSaver = new ReportSaver();

        IStorage<Report> reportStorage = reportStorageMock.Object;
        reportSaver.Save(report, reportStorage);

        IList<Report> actualReports = reportStorage.Items;
        
        Assert.That(actualReports.Count, Is.EqualTo(expectedReportsList.Count));
        Assert.That(actualReports, Is.EquivalentTo(expectedReportsList));
    }
    
    [Test]
    public void SaveToNotEmptyStorage_SaveTest()
    {
        Report report = new Report();
        Mock<IStorage<Report>> reportStorageMock = new Mock<IStorage<Report>>();

        List<Report> reports = [new Report()];
        
        IList<Report> expectedReportsList = new List<Report>(reports);
        expectedReportsList.Add(report);

        reportStorageMock.Setup(storage => storage.Items).Returns(reports);

        ReportSaver reportSaver = new ReportSaver();

        IStorage<Report> reportStorage = reportStorageMock.Object;
        reportSaver.Save(report, reportStorage);

        IList<Report> actualReports = reportStorage.Items;
        
        Assert.That(actualReports.Count, Is.EqualTo(2));
        Assert.That(actualReports, Is.EquivalentTo(expectedReportsList));
    }
}

public class ReportsData
{
    public static IEnumerable<object[]> ManyReportsTestCases()
    {
        yield return
        [
            new List<Report>()
        ];
        
        yield return
        [
            new List<Report>()
            {
                new Report(),
                new Report()
            }
        ];
        
        yield return
        [
            new List<Report>()
            {
                new Report(),
                new Report(),
                new Report()
            }
        ];
    }
}