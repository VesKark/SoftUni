using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] inputStrings = Console.ReadLine().Split();
        StringBuilder sb = new StringBuilder();

        foreach (string item in inputStrings)
        {            
            for (int i = 0; i < item.Length; i++)
            {
                sb.Append(item);
            }
        }

        Console.WriteLine(sb);
    }
}