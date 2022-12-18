using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> children = new Queue<string>(Console.ReadLine().Split());
        int counter = int.Parse(Console.ReadLine());

        while (children.Count > 1)
        {
            for (int i = 1; i <= counter; i++)
            {
                string currChild = children.Dequeue();

                if (i == counter)
                {
                    Console.WriteLine($"Removed {currChild}");
                }
                else
                {                    
                    children.Enqueue(currChild);
                }
            }
        }

        string winnerChild = children.Dequeue();
        Console.WriteLine($"Last is {winnerChild}");
    }
}
