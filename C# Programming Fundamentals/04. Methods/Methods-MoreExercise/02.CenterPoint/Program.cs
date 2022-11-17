using System;

namespace _02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
			double coordX1 = double.Parse(Console.ReadLine());
			double coordY1 = double.Parse(Console.ReadLine());
			double coordX2 = double.Parse(Console.ReadLine());
			double coordY2 = double.Parse(Console.ReadLine());

			double radiusOne = DiagonalToPoint(coordX1, coordY1);
			double radiusTwo = DiagonalToPoint(coordX2, coordY2);

			if (radiusOne <= radiusTwo)
			{
				Console.Write("({0}, {1})", coordX1, coordY1);
			}
			else
			{
				Console.Write("({0}, {1})", coordX2, coordY2);
			}
		}

		static double DiagonalToPoint(double a, double b)
		{
			double radius = Math.Sqrt(a * a + b * b);
			return radius;
		}
	}
}
