using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string code = Console.ReadLine();
        StringBuilder digits = new StringBuilder();
        StringBuilder letters = new StringBuilder();
        StringBuilder chars = new StringBuilder();

        foreach (char currChar in code)
        {
            if (Char.IsDigit(currChar))
            {
                digits.Append(currChar);
            }
            else if (Char.IsLetter(currChar))
            {
                letters.Append(currChar);
            }
            else
            {
                chars.Append(currChar);
            }
        }

        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(chars);
    }
}