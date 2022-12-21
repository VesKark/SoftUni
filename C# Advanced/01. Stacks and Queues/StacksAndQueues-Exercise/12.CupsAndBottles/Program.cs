using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // input:
        int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] watterBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Queue<int> allCups = new Queue<int>(cupsCapacity);
        Stack<int> allBottles = new Stack<int>(watterBottles);

        // fill cups with water:
        int wastedWater = 0;

        while (allCups.Count > 0 && allBottles.Count > 0)
        {
            int bottle = allBottles.Peek();
            int cup = allCups.Peek();

            if (bottle >= cup)
            {
                wastedWater += bottle - cup;
                allBottles.Pop();
                allCups.Dequeue();
            }
            else
            {
                while (cup > 0)
                {
                    cup -= bottle;
                    allBottles.Pop();

                    if (allBottles.Count == 0)
                    {
                        break;
                    }

                    bottle = allBottles.Peek();
                }

                wastedWater += Math.Abs(cup);
                allCups.Dequeue();
            }
        }

        // output:
        if (allBottles.Count == 0)
        {
            Console.WriteLine("Cups: " + string.Join(" ", allCups));
        }
        else
        {
            Console.WriteLine("Bottles: " + string.Join(" ", allBottles));
        }

        Console.WriteLine($"Wasted litters of water: {wastedWater}");
    }
}