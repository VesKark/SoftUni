using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < input; i++)
            {
                int inputN = int.Parse(Console.ReadLine());
                sumLeft += inputN;
            }
            for (int i = 0; i < input; i++)
            {
                int inputN = int.Parse(Console.ReadLine());
                sumRight += inputN;
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");

            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }
    }
}
