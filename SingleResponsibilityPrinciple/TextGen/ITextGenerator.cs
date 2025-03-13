namespace SingleResponsibilityPrinciple.TextGen;

public interface ITextGenerator
{
    char[] Alphabet { get; }
    string Generate(int textLength);
}