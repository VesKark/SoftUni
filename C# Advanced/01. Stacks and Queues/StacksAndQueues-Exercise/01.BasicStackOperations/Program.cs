using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = values[0]; // push count
        int s = values[1]; // pop count
        int x = values[2]; // contains value

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> numbersStack = new Stack<int>(numbers);

        for (int i = 0; i < s; i++)
        {
            numbersStack.Pop();
        }

        if (numbersStack.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (numbersStack.Contains(x))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(numbersStack.Min());
        }
    }
}