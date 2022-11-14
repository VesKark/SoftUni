using System;
using System.Linq;

namespace _11.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input two arrays:
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();

            int maxLengthStart = 0;
            int maxLengthEnd = 0;
            int arrayLength = Math.Min(arrayOne.Length, arrayTwo.Length);

            // Finding max lenght of common start:
            for (int i = 0; i < arrayLength; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    maxLengthStart++;
                }
                else
                {
                    break;
                }
            }

            // Finding max lenght of common end (reverse array):
            Array.Reverse(arrayOne);
            Array.Reverse(arrayTwo);

            for (int i = 0; i < arrayLength; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    maxLengthEnd++;
                }
                else
                {
                    break;
                }
            }

            // Printing result:
            if (maxLengthStart >= maxLengthEnd)
            {
                Console.WriteLine(maxLengthStart);
            }
            else
            {
                Console.WriteLine(maxLengthEnd);
            }
        }
    }
}
