internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfStrings = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStrings; i++)
        {
            string inputString = Console.ReadLine();
            string name = FindTextBetweenChars(inputString, '@', '|');
            int age = int.Parse(FindTextBetweenChars(inputString, '#', '*'));

            Console.WriteLine($"{name} is {age} years old.");
        }
    }

    public static string FindTextBetweenChars(string text, char start, char end)
    { 
        int startIndex = text.IndexOf(start) + 1;
        int endIndex = text.IndexOf(end);
        return text.Substring(startIndex, endIndex - startIndex);
    }
}