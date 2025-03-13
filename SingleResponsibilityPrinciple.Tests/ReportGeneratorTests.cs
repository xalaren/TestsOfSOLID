using Moq;
using SingleResponsibilityPrinciple.Reports;
using SingleResponsibilityPrinciple.TextGen;

namespace SingleResponsibilityPrinciple.Tests;

public class ReportGeneratorTests
{
    [TestCase(0, "")]
    [TestCase(3, "AAA")]
    public void CheckCorrespondingTextLength_GenerateTest(int expectedReportLength, string expectedText)
    {
        Mock<ITextGenerator> mockTextGenerator = new Mock<ITextGenerator>();
        mockTextGenerator.Setup(gen => gen.Generate(expectedReportLength)).Returns(expectedText);
        
        ReportGenerator reportGenerator = new ReportGenerator(mockTextGenerator.Object);

        Report report = reportGenerator.Generate(expectedReportLength);
        
        Assert.IsNotNull(report);
        Assert.That(report.Content.Length, Is.EqualTo(expectedReportLength));
    }
    
    
    [TestCase(1)]
    [TestCase(10)]
    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(-10)]
    public void CheckReportIsNotNull_GenerateTest(int reportLength)
    {
        Mock<ITextGenerator> mockTextGenerator = new Mock<ITextGenerator>();
        mockTextGenerator.Setup(gen => gen.Generate(reportLength)).Returns("");
        
        ReportGenerator reportGenerator = new ReportGenerator(mockTextGenerator.Object);

        Report report = reportGenerator.Generate(reportLength);
        
        Assert.IsNotNull(report);
    }
    
    
    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(-10)]
    public void CheckContentEmpty_GenerateTest(int reportLength)
    {
        Mock<ITextGenerator> mockTextGenerator = new Mock<ITextGenerator>();
        mockTextGenerator.Setup(gen => gen.Generate(reportLength)).Returns("");
        
        ReportGenerator reportGenerator = new ReportGenerator(mockTextGenerator.Object);
        
        Report report = reportGenerator.Generate(reportLength);
        Assert.IsEmpty(report.Content);
    }
    
    [TestCase(1, "A")]
    [TestCase(4, "AAAA")]
    public void CheckContentIsNotEmptyAndCorrespondingToExpectedText_GenerateTest(int reportLength, string expectedText)
    {
        Mock<ITextGenerator> mockTextGenerator = new Mock<ITextGenerator>();
        mockTextGenerator.Setup(gen => gen.Generate(reportLength)).Returns(expectedText);
        
        ReportGenerator reportGenerator = new ReportGenerator(mockTextGenerator.Object);
        
        Report report = reportGenerator.Generate(reportLength);
        
        Assert.IsNotNull(report);
        Assert.IsNotEmpty(report.Content);
        Assert.That(report.Content, Is.EqualTo(expectedText));
    }
}