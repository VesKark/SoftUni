using System;

namespace _01.TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideB1 = double.Parse(Console.ReadLine());
            double sideB2 = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double trapezoidArea = (sideB1 + sideB2) * height / 2;
            Console.WriteLine($"{trapezoidArea:F2}");
        }
    }
}
