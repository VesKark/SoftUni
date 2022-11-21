internal class Program
{
    private static void Main(string[] args)
    {
        string removeKey = Console.ReadLine().ToLower();
        string text = Console.ReadLine();

        while (text.Contains(removeKey))
        {
            text = text.Replace(removeKey, "");
        }

        Console.WriteLine(text);
    }
}