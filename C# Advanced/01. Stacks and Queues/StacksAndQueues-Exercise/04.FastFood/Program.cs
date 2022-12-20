using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int foodQty = int.Parse(Console.ReadLine());
        Queue<int> foodOrders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

        Console.WriteLine(foodOrders.Max());

        // process orders:
        int countOrders = foodOrders.Count();

        for (int i = 0; i < countOrders; i++)
        {
            if (foodQty >= foodOrders.Peek())
            {
                foodQty -= foodOrders.Peek();
                foodOrders.Dequeue();
            }
            else
            {
                break;
            }
        }

        // print orders left:
        if (foodOrders.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine("Orders left: " + string.Join(" ", foodOrders));
        }
    }
}