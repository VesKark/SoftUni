using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = Console.ReadLine();

			while (command != "end")
			{
				string[] currentCommand = command.Split();
				string action = currentCommand[0];
				int num = int.Parse(currentCommand[1]);

				if (action == "Add")
				{
					numbers.Add(num);
				}
				else if (action == "Remove")
				{
					numbers.Remove(num);
				}
				else if (action == "RemoveAt")
				{
					numbers.RemoveAt(num);
				}
				else if (action == "Insert")
				{
					int index = int.Parse(currentCommand[2]);
					numbers.Insert(index, num);
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
    }
}
