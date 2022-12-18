using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> customers = new Queue<string>();
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            if (input == "Paid")
            {
                foreach (string name in customers)
                {
                    Console.WriteLine(name);
                }
                customers.Clear();
            }
            else
            {
                customers.Enqueue(input);
            }
        }

        Console.WriteLine($"{customers.Count} people remaining.");
    }
}
