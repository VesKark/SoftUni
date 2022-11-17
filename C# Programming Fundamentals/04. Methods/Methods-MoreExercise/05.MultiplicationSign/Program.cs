using System;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());

            int[] array = { numA, numB, numC };
            Console.WriteLine(MultiplicationSign(array));
        }

        static string MultiplicationSign(int[] array)
        {
            int countNegative = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    countNegative++;
                }
                else if (array[i] == 0)
                {
                    return "zero";
                }
            }

            if (countNegative % 2 != 0)
            {
                return "negative";
            }

            return "positive";
        }
    }
}
