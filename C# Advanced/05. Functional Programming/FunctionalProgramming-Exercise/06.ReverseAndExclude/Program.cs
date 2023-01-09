using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        numbers.Reverse();

        int divNum = int.Parse(Console.ReadLine());
        Predicate<int> isNotDivisible = number => number % divNum != 0;

        Action<List<int>> printList = list => Console.WriteLine(string.Join(" ", list.FindAll(isNotDivisible)));
        printList(numbers);
    }
}