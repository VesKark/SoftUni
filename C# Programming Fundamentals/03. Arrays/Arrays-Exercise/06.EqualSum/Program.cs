using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Find sum to the Left and Right of array elements:
            int sumLeft = 0;
            int sumRight = 0;
            bool noEquals = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                {
                    sumLeft += array[i - 1];
                }

                for (int j = array.Length - 1; j > i; j--)
                {
                    sumRight += array[j];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    noEquals = false;
                    break;
                }

                sumRight = 0;
            }

            if (noEquals)
            {
                Console.WriteLine("no");
            }
        }
    }
}
