using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            StringBuilder reversedInput = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput.Append(input[i]);
            }

            Console.WriteLine($"{input} = {reversedInput}");

            input = Console.ReadLine();
        }
    }
}