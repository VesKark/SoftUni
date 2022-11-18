using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
			// Input:
			List<int> cardsPlayerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> cardsPlayerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

			while (cardsPlayerOne.Any() && cardsPlayerTwo.Any())
			{
				if (cardsPlayerOne[0] > cardsPlayerTwo[0])
				{
					int temp = cardsPlayerOne[0];
					cardsPlayerOne.Add(temp);
					cardsPlayerOne.Add(cardsPlayerTwo[0]);
				}
				else if (cardsPlayerOne[0] < cardsPlayerTwo[0])
				{
					int temp = cardsPlayerTwo[0];
					cardsPlayerTwo.Add(temp);
					cardsPlayerTwo.Add(cardsPlayerOne[0]);
				}
				cardsPlayerOne.RemoveAt(0);
				cardsPlayerTwo.RemoveAt(0);
			}

			// Output:
			string winner = "Second";
			int winnerSum = cardsPlayerTwo.Sum();

			if (cardsPlayerOne.Any())
			{
				winner = "First";
				winnerSum = cardsPlayerOne.Sum();
			}

			Console.WriteLine("{0} player wins! Sum: {1}", winner, winnerSum);
		}
    }
}
