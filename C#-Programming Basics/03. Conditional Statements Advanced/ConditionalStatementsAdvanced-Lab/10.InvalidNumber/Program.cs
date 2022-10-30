using System;

namespace _10.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int number = int.Parse(Console.ReadLine());

            // Output - invalid if not in range [100, 200] or equal [0]:
            bool isValid = number == 0 || (number >= 100 && number <= 200);
            if (!isValid)
            {
                Console.WriteLine("invalid");
            }            
        }
    }
}
