using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
			int commandsCount = int.Parse(Console.ReadLine());
			List<string> guestList = new List<string>();

			for (int i = 0; i < commandsCount; i++)
			{
				string[] guestNameAndStatus = Console.ReadLine().Split();
				string guestName = guestNameAndStatus[0];
				bool isGoing = guestNameAndStatus.Length == 3;
				bool isInTheList = guestList.Contains(guestName);

				if (isGoing && !isInTheList)
				{
					guestList.Add(guestName);
				}
				else if (isGoing && isInTheList)
				{
					Console.WriteLine("{0} is already in the list!", guestName);
				}
				else if (!isGoing && isInTheList)
				{
					guestList.Remove(guestName);
				}
				else if (!isGoing && !isInTheList)
				{
					Console.WriteLine("{0} is not in the list!", guestName);
				}
			}

			foreach (string guest in guestList)
			{
				Console.WriteLine(guest);
			}
		}
    }
}
