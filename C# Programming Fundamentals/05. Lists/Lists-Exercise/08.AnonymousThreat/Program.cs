using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
			List<string> input = Console.ReadLine().Split().ToList();
			string command = Console.ReadLine();

			while (command != "3:1")
			{
				string[] currentCommand = command.Split();
				string action = currentCommand[0];
				int index = int.Parse(currentCommand[1]);
				int count = int.Parse(currentCommand[2]);

				if (action == "merge")
				{
					if (index < 0)
					{
						index = 0;
					}
					else if (index >= input.Count)
					{
						index = input.Count - 1;
					}

					for (int i = 0; i < count - index; i++)
					{
						if ((index + 1) < input.Count)
						{
							input[index] += input[index + 1];
							input.RemoveAt(index + 1);
						}
					}
				}
				else if (action == "divide")
				{
					int length = input[index].Length;
					int lengthUnit = length / count;
					string indexValue = input[index];
					string sub = "";

					if (length % count == 0)
					{
						for (int i = 0; i < count; i++)
						{
							sub = indexValue.Substring(i * lengthUnit, lengthUnit);
							if (i > 0)
							{
								input.Insert(index + i, sub);
							}
							else if (i == 0)
							{
								input[index + i] = sub;
							}
						}
					}
					else if (length % count != 0)
					{
						for (int i = 0; i < count; i++)
						{
							if (i != count - 1)
							{
								sub = indexValue.Substring(i * lengthUnit, lengthUnit);
							}
							else if (i == count - 1)
							{
								sub = indexValue.Substring(i * lengthUnit);
							}

							if (i > 0)
							{
								input.Insert(index + i, sub);
							}
							else if (i == 0)
							{
								input[index + i] = sub;
							}
						}
					}
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", input));
		}
    }
}
