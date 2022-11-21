using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        int explosionStrength = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (explosionStrength > 0 && text[i] != '>')
            {
                explosionStrength--;
                continue;
            }

            if (text[i] == '>')
            {
                explosionStrength += (text[i + 1]) - 48;
            }

            sb.Append(text[i]);
        }

        Console.WriteLine(sb);
    }
}