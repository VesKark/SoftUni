using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double raisedNumber = RaisedNumber(number, power);
            Console.WriteLine(raisedNumber);
        }

        static double RaisedNumber(double a, int b)
        {
            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}
