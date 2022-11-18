using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

			numbers.RemoveAll(x => x < 0);

			if (numbers.Any())
			{
				numbers.Reverse();
				Console.WriteLine(string.Join(" ", numbers));
			}
			else
			{
				Console.WriteLine("empty");
			}
		}
    }
}
