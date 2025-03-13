using System.Text;

namespace SingleResponsibilityPrinciple.TextGen;

public class RandomTextGenerator : ITextGenerator
{
    public char[] Alphabet => SimpleCharactersCollection.Characters;

    public string Generate(int textLength)
    {
        Random random = new Random();
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < textLength; i++)
        {
            int index = random.Next(Alphabet.Length);
            stringBuilder.Append(Alphabet[index]);
        }

        return stringBuilder.ToString();
    }
}