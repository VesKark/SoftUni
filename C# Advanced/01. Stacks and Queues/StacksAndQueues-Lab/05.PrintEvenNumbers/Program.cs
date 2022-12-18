using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> queueInt = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0));

        Console.WriteLine(string.Join(", ", queueInt));
    }
}