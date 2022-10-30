using System;

namespace _08.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleRadius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * circleRadius * circleRadius;
            double circlePerimeter = 2 * Math.PI * circleRadius;

            Console.WriteLine($"{circleArea:F2}");
            Console.WriteLine("{0:F2}", circlePerimeter);        
        }
    }
}
