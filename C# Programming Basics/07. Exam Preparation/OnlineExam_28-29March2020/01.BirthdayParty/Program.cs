using System;

namespace _01.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double hallRent = double.Parse(Console.ReadLine());

            // Estimating costs for the birthday party:
            double cake = hallRent * 0.20;
            double drinks = cake * 0.55; //45% less than cake price
            double animator = hallRent / 3;

            // Output:
            double budget = hallRent + cake + drinks + animator;
            Console.WriteLine(budget);
        }
    }
}
