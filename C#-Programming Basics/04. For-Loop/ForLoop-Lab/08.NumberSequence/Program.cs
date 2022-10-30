using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            int inputN = 0;

            for (int i = 0; i < n; i++)
            {
                inputN = int.Parse(Console.ReadLine());
                if (inputN > max)
                {
                    max = inputN;
                }

                if (inputN < min)
                {
                    min = inputN;
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
