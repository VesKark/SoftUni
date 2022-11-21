using System;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string inputText = string.Empty;
        StringBuilder decryptMessage = new StringBuilder();

        while ((inputText = Console.ReadLine()) != "find")
        {
            for (int i = 0; i < inputText.Length; i++)
            {
                int indexInKey = i;

                if (i >= key.Length)
                {
                    indexInKey = i % key.Length;
                }

                decryptMessage.Append((char)(inputText[i] - key[indexInKey]));
            }

            string treasureType = FindTextBetweenChars(decryptMessage.ToString(), '&', '&');
            string treasureCoord = FindTextBetweenChars(decryptMessage.ToString(), '<', '>');

            Console.WriteLine("Found {0} at {1}", treasureType, treasureCoord);

            decryptMessage.Clear();
        }
    }

    public static string FindTextBetweenChars(string text, char a, char b)
    {
        int startIndext = text.IndexOf(a) + 1;
        int endIndex = text.LastIndexOf(b);

        string outputText = text.Substring(startIndext, endIndex - startIndext);
        return outputText;
    }
}