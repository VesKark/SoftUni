using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        string command = string.Empty;

        while ((command = Console.ReadLine().ToLower()) != "end")
        {
            string[] currCommand = command.Split();
            string action = currCommand[0];
            int numA = int.Parse(currCommand[1]);

            if (action == "add")
            {
                int numB = int.Parse(currCommand[2]);
                numbers.Push(numA);
                numbers.Push(numB);
            }
            else if (action == "remove")
            {
                if (numA > numbers.Count)
                {
                    continue;
                }
                else
                {
                    for (int i = 0; i < numA; i++)
                    {
                        numbers.Pop();
                    }
                }
            }
        }

        Console.WriteLine($"Sum: {numbers.Sum()}");
    }
}