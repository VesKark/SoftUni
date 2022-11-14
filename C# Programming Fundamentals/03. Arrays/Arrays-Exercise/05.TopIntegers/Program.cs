using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input integer array:
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Finding and printing T0P integers (bigger than all the elements to thier right):
            bool isTop = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTop = false;
                    }
                }

                if (isTop)
                {
                    Console.Write(array[i] + " ");
                }

                isTop = true;
            }

            // Printing last array element (always T0P):
            Console.WriteLine(array[array.Length - 1]);
        }
    }
}
