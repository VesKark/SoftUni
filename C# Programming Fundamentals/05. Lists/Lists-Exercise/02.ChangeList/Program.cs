using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.ChangeList
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
				int element = int.Parse(currentCommand[1]);

				if (action == "Delete")
				{
					numbers.RemoveAll(x => x == element);
				}
				else if (action == "Insert")
				{
					int index = int.Parse(currentCommand[2]);
					numbers.Insert(index, element);
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
    }
}
