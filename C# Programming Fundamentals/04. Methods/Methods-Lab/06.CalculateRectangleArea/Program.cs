using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = RectangleArea(width, height);
            Console.WriteLine(area);
        }

        static int RectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
