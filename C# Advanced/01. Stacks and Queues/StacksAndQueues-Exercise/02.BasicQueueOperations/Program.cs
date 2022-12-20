using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = values[0]; // enqueue count
        int s = values[1]; // dequeue count
        int x = values[2]; // contains value       

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Queue<int> numbersQueue = new Queue<int>(numbers);

        for (int i = 0; i < s; i++)
        {
            numbersQueue.Dequeue();
        }

        if (numbersQueue.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (numbersQueue.Contains(x))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(numbersQueue.Min());
        }
    }
}