using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
			int wagonCapacity = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();

			while (command != "end")
			{
				int passengers;
				bool newPassengers = int.TryParse(command, out passengers);

				if (newPassengers)
				{
					for (int i = 0; i < wagons.Count; i++)
					{
						if (wagons[i] + passengers <= wagonCapacity)
						{
							wagons[i] += passengers;
							break;
						}
					}
				}
				else
				{
					string[] addWagon = command.Split();
					int newWagon = int.Parse(addWagon[1]);
					wagons.Add(newWagon);
				}

				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", wagons));
		}
    }
}
