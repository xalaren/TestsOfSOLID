using System.Security.Cryptography;
using SingleResponsibilityPrinciple.TextGen;

namespace SingleResponsibilityPrinciple.Tests;

[TestFixture]
public class RandomTextGeneratorTests
{
    private RandomTextGenerator randomTextGen;
    
    [SetUp]
    public void Setup()
    {
        randomTextGen = new RandomTextGenerator();
    }

    [TestCase(0)]
    [TestCase(20)]
    public void CheckCorrespondingTextLength_GenerateTest(int expectedTextLength)
    {
        var generatedText = randomTextGen.Generate(expectedTextLength);
        Assert.That(generatedText.Length, Is.EqualTo(expectedTextLength));
    }

    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(-10)]
    public void CheckStringEmpty_GenerateTest(int textLength)
    {
        var generatedText = randomTextGen.Generate(textLength);
        Assert.IsEmpty(generatedText);
    }
    
    [TestCase(1)]
    [TestCase(10)]
    [TestCase(1)]
    public void CheckStringIsNotNullAndNotEmpty_GenerateTest(int textLength)
    {
        var generatedText = randomTextGen.Generate(textLength);
        Assert.IsNotNull(generatedText);
        Assert.IsNotEmpty(generatedText);
    }
}