using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.PokemonDon_tGo
{
    class Program
    {
		static void Main(string[] args)
		{
			List<int> distance = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
			int index = int.Parse(Console.ReadLine());
			int sum = 0;

			while (distance.Any())
			{
				int temp;

				if (index < 0)
				{
					temp = distance[0];
					sum += temp;
					distance[0] = distance[distance.Count - 1];
				}
				else if (index >= distance.Count)
				{
					temp = distance[distance.Count - 1];
					sum += temp;
					distance[distance.Count - 1] = distance[0];
				}
				else
				{
					temp = distance[index];
					sum += temp;
					distance.RemoveAt(index);
				}

				if (distance.Any())
				{
					IncreaseDecreaseValues(distance, temp);
				}
				else
				{
					break;
				}

				index = int.Parse(Console.ReadLine());
			}

			Console.WriteLine(sum);
		}

		static void IncreaseDecreaseValues(List<int> distance, int temp)
		{
			for (int i = 0; i < distance.Count; i++)
			{
				if (distance[i] <= temp)
				{
					distance[i] += temp;
				}
				else
				{
					distance[i] -= temp;
				}
			}
		}
	}
}
