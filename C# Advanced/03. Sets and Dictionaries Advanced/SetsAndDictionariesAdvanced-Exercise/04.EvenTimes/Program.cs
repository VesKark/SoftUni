using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int inputCount = int.Parse(Console.ReadLine());
        Dictionary<int, int> findEven = new Dictionary<int, int>();

        for (int i = 0; i < inputCount; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (!findEven.ContainsKey(number))
            {
                findEven[number] = 1;
            }
            else
            {
                findEven[number] += 1;
            }
        }

        Console.WriteLine(findEven.First(elem => elem.Value % 2 == 0).Key);
    }
}