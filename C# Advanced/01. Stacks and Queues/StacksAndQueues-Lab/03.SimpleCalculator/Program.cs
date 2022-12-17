using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] equation = Console.ReadLine().Split();
        Stack<string> equationStack = new Stack<string>();

        for (int i = equation.Length - 1; i >= 0; i--)
        {
            equationStack.Push(equation[i]);
        }

        // calculate equation:
        int result = int.Parse(equationStack.Pop());

        while (equationStack.Count > 0)
        {
            char operation = char.Parse(equationStack.Pop());
            int number = int.Parse(equationStack.Pop());

            if (operation == '+')
            {
                result += number;
            }
            else if (operation == '-')
            {
                result -= number;
            }
        }

        Console.WriteLine(result);
    }
}