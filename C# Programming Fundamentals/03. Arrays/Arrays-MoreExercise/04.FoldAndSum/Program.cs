using System;
using System.Linq;

namespace _04.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int[] arrayInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Fold and sum array:
            int foldedLength = arrayInput.Length / 4;
            int[] arrayMiddle = new int[foldedLength * 2];

            for (int i = 0; i < foldedLength * 2; i++)
            {
                arrayMiddle[i] = arrayInput[foldedLength + i];
            }

            for (int i = 0; i < foldedLength; i++)
            {
                // Assigning left part of array:
                arrayMiddle[i] = arrayMiddle[i] + arrayInput[foldedLength - 1 - i];
                // Assigning right part of array:
                arrayMiddle[2 * foldedLength - 1 - i] = arrayMiddle[2 * foldedLength - 1 - i] + arrayInput[foldedLength * 3 + i];
            }

            // Output result:
            Console.WriteLine(string.Join(" ", arrayMiddle));
        }
    }
}
