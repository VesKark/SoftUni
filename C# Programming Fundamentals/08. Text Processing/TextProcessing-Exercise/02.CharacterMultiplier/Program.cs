internal class Program
{
    private static void Main(string[] args)
    {
        string[] inputStrings = Console.ReadLine().Split();
        string stringA = inputStrings[0];
        string stringB = inputStrings[1];
        int totalSum = 0;

        if (stringA.Length < stringB.Length)
        { 
            string temp = stringA;
            stringA = stringB;
            stringB = temp;
        }

        for (int i = 0; i < stringA.Length; i++)
        {
            if (i >= stringB.Length)
            {
                totalSum += stringA[i];
            }
            else
            {
                totalSum += stringA[i] * stringB[i];
            }
        }

        Console.WriteLine(totalSum);
    }
}