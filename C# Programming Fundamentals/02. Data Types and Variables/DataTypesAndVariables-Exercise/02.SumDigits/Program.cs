using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input integer:
            int inputNum = int.Parse(Console.ReadLine());

            // Output sum of its digits:
            int sum = 0;

            while (inputNum > 0)
            {
                sum += inputNum % 10;
                inputNum /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
