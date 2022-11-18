using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = Console.ReadLine();
			bool printList = false;

			while (command != "end")
			{
				string[] currentCommand = command.Split();
				string action = currentCommand[0];

				if (action == "Add")
				{
					int num = int.Parse(currentCommand[1]);
					numbers.Add(num);
					printList = true;
				}
				else if (action == "Remove")
				{
					int num = int.Parse(currentCommand[1]);
					numbers.Remove(num);
					printList = true;
				}
				else if (action == "RemoveAt")
				{
					int num = int.Parse(currentCommand[1]);
					numbers.RemoveAt(num);
					printList = true;
				}
				else if (action == "Insert")
				{
					int num = int.Parse(currentCommand[1]);
					int index = int.Parse(currentCommand[2]);
					numbers.Insert(index, num);
					printList = true;
				}
				else if (action == "Contains")
				{
					int num = int.Parse(currentCommand[1]);
					if (numbers.Contains(num))
					{
						Console.WriteLine("Yes");
					}
					else
					{
						Console.WriteLine("No such number");
					}
				}
				else if (action == "PrintEven")
				{
					Console.WriteLine(string.Join(" ", numbers.FindAll(x => x % 2 == 0)));
				}
				else if (action == "PrintOdd")
				{
					Console.WriteLine(string.Join(" ", numbers.FindAll(x => x % 2 != 0)));
				}
				else if (action == "GetSum")
				{
					Console.WriteLine(numbers.Sum());
				}
				else if (action == "Filter")
				{
					string sign = currentCommand[1]; //"<", ">", ">=" or "<="
					int num = int.Parse(currentCommand[2]);
					switch (sign)
					{
						case "<": Console.WriteLine(string.Join(" ", numbers.FindAll(x => x < num))); break;
						case ">": Console.WriteLine(string.Join(" ", numbers.FindAll(x => x > num))); break;
						case ">=": Console.WriteLine(string.Join(" ", numbers.FindAll(x => x >= num))); break;
						case "<=": Console.WriteLine(string.Join(" ", numbers.FindAll(x => x <= num))); break;
					}
				}

				command = Console.ReadLine();
			}

			if (printList)
			{
				Console.WriteLine(string.Join(" ", numbers));
			}
		}
    }
}
