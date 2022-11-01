using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = squareSide * squareSide;
                Console.WriteLine($"{squareArea:F3}");
            }
            else if (figure == "rectangle")
            {
                double rectangleSideA = double.Parse(Console.ReadLine());
                double rectangleSideB = double.Parse(Console.ReadLine());
                double rectangleArea = rectangleSideA * rectangleSideB;
                Console.WriteLine("{0:F3}", rectangleArea);
            }
            else if (figure == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * circleRadius * circleRadius;
                Console.WriteLine($"{circleArea:F3}");
            }
            else if (figure == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                double triangleArea = triangleSide * triangleHeight / 2;
                Console.WriteLine("{0:F3}", triangleArea);
            }
        }
    }
}
