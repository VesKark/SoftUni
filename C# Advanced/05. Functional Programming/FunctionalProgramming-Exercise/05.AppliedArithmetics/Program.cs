using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

        string command = Console.ReadLine();

        while (command != "end")
        {
            Func<int[], int[]> operation = null;

            switch (command)
            {
                case "add": operation = numbers => numbers.Select(num => num + 1).ToArray(); break;
                case "multiply": operation = numbers => numbers.Select(num => num * 2).ToArray(); break;
                case "subtract": operation = numbers => numbers.Select(num => num - 1).ToArray(); break;
            }

            if (command == "print")
            {
                print(numbers);
            }
            else
            {
                numbers = operation(numbers);
            }

            command = Console.ReadLine();
        }
    }
}