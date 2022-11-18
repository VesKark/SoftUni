using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
			int[] bombing = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int bombNumber = bombing[0];
			int bombPower = bombing[1];

			for (int i = 0; i < sequence.Count; i++)
			{
				if (sequence[i] == bombNumber)
				{
					sequence[i] = 0;
					for (int j = 1; j <= bombPower; j++)
					{
						if (i - j >= 0)
						{
							sequence[i - j] = 0;
						}
						if (i + j < sequence.Count)
						{
							sequence[i + j] = 0;
						}
					}
				}
			}

			Console.WriteLine(sequence.Sum());
		}
    }
}
