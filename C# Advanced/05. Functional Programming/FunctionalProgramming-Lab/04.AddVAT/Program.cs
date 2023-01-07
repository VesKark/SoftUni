using System;
using System.Collections.Generic;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        Func<double, double> addVAT = price => price * 1.20;
        Action<double> print2afterDecimal = price => Console.WriteLine("{0:F2}", price);

        Console.ReadLine()
            .Split(", ")
            .Select(double.Parse)
            .Select(addVAT)
            .ToList()
            .ForEach(print2afterDecimal);
    }
}