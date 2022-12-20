using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> clothing = new Stack<int>(input);
        int rackCapacity = int.Parse(Console.ReadLine());

        int rackCount = 0;

        while (clothing.Count > 0)
        {
            int sumPerRack = 0;

            while (sumPerRack + clothing.Peek() <= rackCapacity)
            {
                sumPerRack += clothing.Peek();
                clothing.Pop();

                if (clothing.Count == 0)
                {
                    break;
                }
            }

            rackCount++;
        }

        Console.WriteLine(rackCount);
    }
}