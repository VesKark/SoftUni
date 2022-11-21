using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();
        StringBuilder encrytedText = new StringBuilder();

        foreach (char currChar in text)
        {
            encrytedText.Append((char)(currChar + 3));
        }

        Console.WriteLine(encrytedText);
    }
}