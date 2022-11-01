using System;

namespace _02.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            double triangleArea = triangleSide * triangleHeight / 2;
            Console.WriteLine($"{triangleArea:F2}");
        }
    }
}
