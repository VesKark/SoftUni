using System;
using System.Linq;

namespace _17.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            // Counting elements building difference:
            int counter = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i] + difference || array[j] == array[i] - difference)
                    {
                        counter++;
                    }
                }
            }

            // Output:
            Console.WriteLine(counter);
        }
    }
}
