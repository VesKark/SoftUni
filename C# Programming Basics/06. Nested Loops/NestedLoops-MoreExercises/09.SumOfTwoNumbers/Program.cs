using System;

namespace _09.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            // Generating combinations:
            int counter = 0;
            bool finish = true;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {i + j})");
                        finish = false;
                        return;
                    }                    
                }
            }

            if (finish)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
