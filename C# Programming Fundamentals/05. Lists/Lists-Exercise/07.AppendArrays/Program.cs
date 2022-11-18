using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] input = Console.ReadLine().Split('|');
			List<string> output = new List<string>();

			for (int i = 0; i < input.Length; i++)
			{
				string current = input[i];
				List<string> currentList = current.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
				output.InsertRange(0, currentList);
			}

			Console.WriteLine(string.Join(" ", output));
		}
    }
}
