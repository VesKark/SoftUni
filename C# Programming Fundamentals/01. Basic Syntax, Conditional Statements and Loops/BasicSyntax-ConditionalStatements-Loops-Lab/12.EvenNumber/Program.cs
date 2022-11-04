using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int number = int.Parse(Console.ReadLine());

            // Output:
            while (number % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
