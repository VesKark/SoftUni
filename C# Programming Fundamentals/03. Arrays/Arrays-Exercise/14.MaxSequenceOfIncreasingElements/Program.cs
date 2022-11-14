using System;
using System.Linq;

namespace _14.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array:
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Find the longest to the left sequence:
            int counter = 1;
            int counterMax = 1;
            int index = 0;
            int indexEnd = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    counter++;
                    index = i + 1;
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        indexEnd = index;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            // Print result:
            for (int i = indexEnd - counterMax + 1; i <= indexEnd; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
