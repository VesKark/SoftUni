using System;

namespace _09.LastKnumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int n = int.Parse(Console.ReadLine()); //length of sequence
            int k = int.Parse(Console.ReadLine()); //count of last sequence elements to sum

            // Assigning array of sumed elements:
            long[] sequence = new long[n];
            sequence[0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (j < i)
                    {
                        sequence[i] += sequence[i - 1 - j];
                    }
                }
            }

            // Printing sequence:
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
