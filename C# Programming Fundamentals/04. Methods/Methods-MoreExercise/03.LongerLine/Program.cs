using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void CloserPoint(double x, double y, double z, double p) // determines which point is closer to (0,0)
        {
            if (x * x + y * y <= z * z + p * p)
                Console.WriteLine($"({x}, {y})({z}, {p})");
            else
                Console.WriteLine($"({z}, {p})({x}, {y})");
        }

        static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double z1 = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2); // first line
            double z2 = Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2); // second line

            if (z1 >= z2)
                CloserPoint(x1, y1, x2, y2);
            else
                CloserPoint(x3, y3, x4, y4);
        }
    }
}
