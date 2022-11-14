using System;
using System.Linq;

namespace _10.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array of integers:
            int[] arrayInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Finding and printing elements "a + b == c" (a always to the left of b):
            bool notFound = true;

            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i + 1; j < arrayInput.Length; j++)
                {
                    for (int z = 0; z < arrayInput.Length; z++)
                    {
                        if (arrayInput[i] + arrayInput[j] == arrayInput[z])
                        {
                            Console.WriteLine($"{arrayInput[i]} + {arrayInput[j]} == {arrayInput[z]}");
                            notFound = false;
                            break;
                        }
                    }
                }
            }

            if (notFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
