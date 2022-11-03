using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int inputN = int.Parse(Console.ReadLine());
                sum += inputN;
                if (inputN > max)
                {
                    max = inputN;
                }
            }

            if (max == sum - max)
            {
                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(sum - max - max)}");
            }
        }
    }
}
