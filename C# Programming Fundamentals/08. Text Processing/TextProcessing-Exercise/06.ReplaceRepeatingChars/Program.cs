using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            while (i < text.Length - 1 && text[i] == text[i + 1])
            {
                i++;
            }

            sb.Append(text[i]);
        }

        Console.WriteLine(sb);
    }
}