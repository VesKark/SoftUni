using System;

namespace _13.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int num = int.Parse(Console.ReadLine());

            // Assigning integer array:
            int[] intArray = new int[num + 1];

            for (int i = 0; i <= num; i++)
            {
                intArray[i] = i;
            }

            // Assigning boolean array:
            bool[] boolArray = new bool[num + 1]; //default values = False
            for (int i = 2; i <= num; i++)
            {
                boolArray[i] = true;
            }

            // Finding and printing prime numbers:
            for (int i = 2; i <= num; i++)
            {
                if (boolArray[i] == true)
                {
                    Console.Write(intArray[i] + " ");

                    for (int j = 2; j <= num / i; j++)
                    {
                        boolArray[i * j] = false;
                    }
                }
            }
        }
    }
}
