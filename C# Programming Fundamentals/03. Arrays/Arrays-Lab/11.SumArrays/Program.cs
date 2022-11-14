using System;
using System.Linq;

namespace _11.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Sum arrays per index number:
            int[] arraySum = new int[Math.Max(arrayOne.Length, arrayTwo.Length)];

            for (int i = 0; i < arraySum.Length; i++)
            {
                arraySum[i] = arrayOne[i % arrayOne.Length] + arrayTwo[i % arrayTwo.Length];
            }

            // Printing result:
            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}
