using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int counter = int.Parse(Console.ReadLine());

            // Form arrays:
            int[] arrayOne = new int[counter];
            int[] arrayTwo = new int[counter];

            for (int i = 1; i <= counter; i++)
            {
                int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    arrayOne[i - 1] = inputArray[0];
                    arrayTwo[i - 1] = inputArray[1];
                }
                else
                {
                    arrayOne[i - 1] = inputArray[1];
                    arrayTwo[i - 1] = inputArray[0];
                }
            }

            // Print arrays:
            foreach (var item in arrayOne)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in arrayTwo)
            {
                Console.Write(item + " ");
            }
        }
    }
}
