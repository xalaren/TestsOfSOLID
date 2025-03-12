using System.Text;

namespace SingleResponsibilityPrinciple.TextGen;

public class RandomTextGenerator : ITextGenerator
{
    public string Generate(int textLength)
    {
        char[] alphabet = SimpleCharactersCollection.Characters;
        Random random = new Random();
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < textLength; i++)
        {
            int index = random.Next(alphabet.Length);
            stringBuilder.Append(alphabet[index]);
        }

        return stringBuilder.ToString();
    }
}