internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Dictionary<char, int> countChars = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            char currChar = input[i];

            if (currChar == ' ')
            {
                continue;
            }

            if (!countChars.ContainsKey(currChar))
            {
                countChars.Add(currChar, 0);
            }

            countChars[currChar]++;
        }

        foreach (var currChar in countChars)
        {
            Console.WriteLine($"{currChar.Key} -> {currChar.Value}");
        }
    }
}