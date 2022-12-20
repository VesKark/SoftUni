using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int queries = int.Parse(Console.ReadLine());
        Stack<int> intStack = new Stack<int>();

        for (int i = 0; i < queries; i++)
        {
            string command = Console.ReadLine();

            if (command[0] == '1')
            {
                int pushValue = int.Parse(command.Substring(1));
                intStack.Push(pushValue);
            }
            else if (intStack.Count == 0)
            {
                continue;
            }
            else if (command[0] == '2')
            {
                intStack.Pop();
            }
            else if (command[0] == '3')
            {
                Console.WriteLine(intStack.Max());
            }
            else if (command[0] == '4')
            {
                Console.WriteLine(intStack.Min());
            }
        }

        Console.WriteLine(string.Join(", ", intStack));
    }
}